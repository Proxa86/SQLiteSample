using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;
using System.IO;


namespace SQLiteSample
{
    public partial class Form1 : Form
    {
        private string dbFileName;
        private SQLiteConnection m_dbConn;
        private SQLiteCommand m_sqlCmd;

        public Form1()
        {
            InitializeComponent();

            this.createStripMenuItem.Click += new EventHandler(this.createStripMenuItem_Click);
            this.connectStripMenuItem.Click += new EventHandler(this.connectStripMenuItem_Click);
            this.readAllStripMenuItem.Click += new EventHandler(this.readAllStripMenuItem_Click);
            this.clearTableStripMenuItem.Click += new EventHandler(this.clearTableStripMenuItem_Click);
            this.addStripMenuItem.Click += new EventHandler(this.addStripMenuItem_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_dbConn = new SQLiteConnection();
            m_sqlCmd = new SQLiteCommand();

            dbFileName = "sample.sqlite";
            lbStatusText.Text = "Disconnected";
        }
        
        private void createStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(dbFileName))
                SQLiteConnection.CreateFile(dbFileName);

            try
            {
                m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;

                m_sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS Catalog (id INTEGER PRIMARY KEY AUTOINCREMENT, author TEXT, book TEXT)";
                m_sqlCmd.ExecuteNonQuery();
                lbStatusText.Text = "Create DB";
            }
            catch(SQLiteException ex)
            {
                lbStatusText.Text = "Disconnected";
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void connectStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(dbFileName))
                MessageBox.Show("Please, create DB and blank table (Push \"Create\" button)");

            try
            {
                m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;

                lbStatusText.Text = "Connected";
            }
            catch (SQLiteException ex)
            {
                lbStatusText.Text = "Disconnected";
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void readAllStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();
            String sqlQuery;

            if(m_dbConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Open connection with database");
                return;
            }

            try
            {
                sqlQuery = "SELECT * FROM Catalog";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, m_dbConn);
                adapter.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    dgView.Rows.Clear();

                    for (int i = 0; i < dTable.Rows.Count; i++)
                        dgView.Rows.Add(dTable.Rows[i].ItemArray);
                }
                else
                    MessageBox.Show("Database is empty");
            }
            catch(SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void clearTableStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_dbConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Open connection with database");
                return;
            }

            try
            {
                dgView.Rows.Clear();
                m_sqlCmd.CommandText = "DELETE FROM Catalog";
                m_sqlCmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void addStripMenuItem_Click(object sender, EventArgs e)
        {
            if(m_dbConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Open connection with database");
                return;
            }

            AddDatatoDB addData = new AddDatatoDB();
            if(addData.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    m_sqlCmd.CommandText = "INSERT INTO Catalog ('author', 'book') values ('" 
                        + addData.Author + "', '" + addData.Book + "')";
                    m_sqlCmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
