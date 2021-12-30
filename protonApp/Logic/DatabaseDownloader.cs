using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using protonApp.Model;
using protonApp.Data;

namespace protonApp.Logic
{
    class DatabaseDownloader
    {
        //MySqlConnection sqlConnection = DatabaseConnectionData.sqlConnection;

        public int GetHighestId(string table)
        {
            MySqlConnection sqlConnection = new MySqlConnection(DatabaseConnectionData.connectionData);
            
            try
            {
                sqlConnection.Open(); //SELECT MAX(Id) FROM " + table + " LIMIT 1", sqlConnection
                MySqlCommand sqlCommand = new MySqlCommand("SELECT MAX(Id) FROM wydarzenia LIMIT 1", sqlConnection);
                
                MySqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                int result = 0;
                if (sqlDataReader.Read())
                    result = Convert.ToInt32(sqlDataReader["MAX(Id)"]);
                sqlDataReader.Close();
                return result/*Convert.ToInt32(sqlDataReader["MAX(Id)"])*/;
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return 0;
        }


        public List<Student> GetStudents()
        {
            MySqlConnection sqlConnection = new MySqlConnection(DatabaseConnectionData.connectionData);
            List<Student> result = new List<Student>();
            MySqlCommand sqlCommand = new MySqlCommand("select * from uczniowie", sqlConnection);
            try
            {
                sqlConnection.Open();
                MySqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    result.Add(new Student(
                        Convert.ToInt32(sqlDataReader["Id"]),
                        sqlDataReader["Imie"].ToString(),
                        sqlDataReader["Nazwisko"].ToString(),
                        Convert.ToInt32(sqlDataReader["Klasa_Id"]),
                        Convert.ToInt32(sqlDataReader["Plec"])
                        ));
                }
                sqlDataReader.Close();
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return result;
        }


        public List<Event> GetEvents()
        {
            MySqlConnection sqlConnection = new MySqlConnection(DatabaseConnectionData.connectionData);
            List<Event> result = new List<Event>();
            MySqlCommand sqlCommand = new MySqlCommand("select * from wydarzenia", sqlConnection);
            try
            {
                sqlConnection.Open();
                MySqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    result.Add(new Event(
                        Convert.ToInt32(sqlDataReader["Id"]),
                        sqlDataReader["Nazwa"].ToString(),
                        Convert.ToDateTime(sqlDataReader["Data"])
                        ));
                }
                sqlDataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return result;
        }


        public List<Class> GetClasses()
        {
            MySqlConnection sqlConnection = new MySqlConnection(DatabaseConnectionData.connectionData);
            List<Class> result = new List<Class>();
            MySqlCommand sqlCommand = new MySqlCommand("select * from klasy", sqlConnection);
            try
            {
                sqlConnection.Open();
                MySqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    result.Add(new Class(
                        Convert.ToInt32(sqlDataReader["Id"]),
                        sqlDataReader["Nazwa"].ToString()
                        ));
                }
                sqlDataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return result;
        }


        public List<Log> GetLogs()
        {
            MySqlConnection sqlConnection = new MySqlConnection(DatabaseConnectionData.connectionData);
            List<Log> result = new List<Log>();
            MySqlCommand sqlCommand = new MySqlCommand("select * from log", sqlConnection);
            try
            {
                sqlConnection.Open();
                MySqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    result.Add(new Log(
                        Convert.ToInt32(sqlDataReader["Id"]),
                        Convert.ToInt32(sqlDataReader["Uczen_Id"]),
                        Convert.ToInt32(sqlDataReader["liczba_punktow"]),
                        Convert.ToInt32(sqlDataReader["Przechodnie"]),
                        Convert.ToInt32(sqlDataReader["Wydarzenie_Id"])
                        ));
                }
                sqlDataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return result;
        }

        public List<Student> GetStudentsBySurname(string surname)
        {
            var students = new List<Student>();
            MySqlConnection sqlConnection = new MySqlConnection(DatabaseConnectionData.connectionData);
            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM uczniowie WHERE Nazwisko LIKE '%" + surname + "%'", sqlConnection);
            try
            {
                sqlConnection.Open();
                MySqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                //while (true)
                while(sqlDataReader.Read()){
                students.Add(new Student(
                        Convert.ToInt32(sqlDataReader["Id"]),
                        sqlDataReader["Imie"].ToString(),
                        sqlDataReader["Nazwisko"].ToString(),
                        Convert.ToInt32(sqlDataReader["Klasa_Id"]),
                        Convert.ToInt32(sqlDataReader["Plec"])
                        ));
                }
                sqlDataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return students;
        }

        public Student GetStudentByNameAndSurname(string name, string surname)
        {
            Student student = new Student(0, "", "", 0, -1);
            MySqlConnection sqlConnection = new MySqlConnection(DatabaseConnectionData.connectionData);
            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM uczniowie WHERE Nazwisko='" + surname + "' AND Imie='" + name + "'", sqlConnection);
            try
            {
                sqlConnection.Open();
                MySqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    student.id = Convert.ToInt32(sqlDataReader["Id"]);
                    student.name = Convert.ToString(sqlDataReader["imie"]);
                    student.surname = Convert.ToString(sqlDataReader["nazwisko"]);
                    student.class_id = Convert.ToInt32(sqlDataReader["klasa_id"]);
                    student.sex = Convert.ToInt32(sqlDataReader["plec"]);
                }
                sqlDataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return student;
        }

//public List<Student> GetStudentsBySurname(string surname)
        //{
        //    //List<Student> students = new List<Student>();
        //    //MySqlConnection sqlConnection = new MySqlConnection(DatabaseConnectionData.connectionData);
        //    //MySqlCommand sqlCommand = new MySqlCommand("SELECT")

        //    //try
        //    //{

        //    //}



        //    //return students;
        //}

        public void SetEvent(Event e)
        {
            MySqlConnection sqlConnection = new MySqlConnection(DatabaseConnectionData.connectionData);
            try
            {
                int highestID = this.GetHighestId("wydarzenia");
                string cmd =
                    "INSERT INTO wydarzenia (Id,Nazwa,Data) VALUES (" +
                    (highestID + 1) +
                    ",'" +
                    e.name +
                    "','" +
                    e.date +
                    "')";
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand(cmd, sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }
        public Student GetStudentById(int id)
        {
            MySqlConnection sqlConnection = new MySqlConnection(DatabaseConnectionData.connectionData);
            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM uczniowie WHERE id=" + id, sqlConnection);
            Student student = new Student(0,"","",0,0);

            try
            {
                sqlConnection.Open();
                MySqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    student.id = Convert.ToInt32(sqlDataReader["Id"]);
                    student.name = Convert.ToString(sqlDataReader["imie"]);
                    student.surname = Convert.ToString(sqlDataReader["nazwisko"]);
                    student.class_id = Convert.ToInt32(sqlDataReader["klasa_id"]);
                    student.sex = Convert.ToInt32(sqlDataReader["plec"]);
                }
                sqlDataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return student;
        }
    
        public Class GetClassById(int id)
        {
            MySqlConnection sqlConnection = new MySqlConnection(DatabaseConnectionData.connectionData);
            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM klasy WHERE id=" + id.ToString(), sqlConnection);
            Class klasa = new Class(0, "");
            
            try
            {
                sqlConnection.Open();
                MySqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                
                while (sqlDataReader.Read())
                {
                    klasa.id = Convert.ToInt32(sqlDataReader["Id"]);
                    klasa.name = Convert.ToString(sqlDataReader["Nazwa"]);
                }
                sqlDataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return klasa;
        }
        public int GetStudentIdByParameters(string name, string surname, int Klasa_Id)
        {
            MySqlConnection sqlConnection = new MySqlConnection(DatabaseConnectionData.connectionData);
            MySqlCommand sqlCommand = new MySqlCommand
                ("SELECT * FROM uczniowie WHERE " +
                "Imie='" + name + "' " +
                "and nazwisko='"+surname+"'" +
                " and klasa_id='"+Klasa_Id+"'", sqlConnection);
            int id = 0;

            try
            {
                sqlConnection.Open();
                MySqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    id = Convert.ToInt32(sqlDataReader["Id"]);
                }
                sqlDataReader.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return id;
        }

        public int GetClassIdByName(string name)
        {

            MySqlConnection sqlConnection = new MySqlConnection(DatabaseConnectionData.connectionData);
            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM klasy WHERE Nazwa='" + name + "'", sqlConnection);
            int id = 0;

            try
            {
                sqlConnection.Open();
                MySqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    id = Convert.ToInt32(sqlDataReader["Id"]);
                }
                sqlDataReader.Close();
            }
            catch (Exception e)
            {
                
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return id;
        }

        public void InsertLog(Log log)
        {
            MySqlConnection sqlConnection = new MySqlConnection(DatabaseConnectionData.connectionData);
            try
            {
                //int highestID = this.GetHighestId("wydarzenia");
                string cmd =
                    "INSERT INTO log (Id, Uczeń_Id, Wydarzenie_Id, liczba_punktow, Przechodnie) VALUES (NULL, '" +
                    log.student_id.ToString() +
                    "','" +
                    log.event_id.ToString() +
                    "','" +
                    log.points.ToString() +
                    "','" +
                    log.transitive_points.ToString() +
                    "')";
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand(cmd, sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }
    }
}
