﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SQLite;
using NAudio.Wave;
using BelSekolah.BelSekolahDatabase.Helper;

namespace BelSekolah.BelSekolahDatabase
{
    public class Database
    {
        private WaveOutEvent _waveOutEvent;
        private Mp3FileReader _mp3FileReader;


        public void CreateTable()
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnStringHelper.GetConn()))
            {
                connection.Open();

                string createTableJadwalKhusus = @"
                    CREATE TABLE IF NOT EXISTS JadwalKhusus(
                        JadwalKhususID INTEGER PRIMARY KEY AUTOINCREMENT,
                        IsTrue INTEGER NOT NULL,
                        Waktu TEXT NOT NULL,
                        Hari TEXT NOT NULL,
                        Keterangan TEXT NOT NULL,
                        SoundName TEXT NOT NULL,
                        Sound BLOB  NOT NULL,
                    );";

                string createTableJadwalNormal = @"
                    CREATE TABLE IF NOT EXISTS JadwalNormal(
                        JadwalNormalID INTEGER PRIMARY KEY AUTOINCREMENT,
                        IsTrue INTEGER NOT NULL,
                        Waktu TEXT NOT NULL,
                        Hari TEXT NOT NULL,
                        Keterangan TEXT NOT NULL,
                        SoundName TEXT NOT NULL,
                        Sound BLOB  NOT NULL,
                    );";

                ExecuteNonQuery(createTableJadwalKhusus, connection);
                ExecuteNonQuery(createTableJadwalNormal, connection);
            }
        }

        private void ExecuteNonQuery(string query, SQLiteConnection connection)
        {
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }




        #region simpan sound 
        public void SaveSound(string soundFile, string fileName)
        {
            // Cek jika file ada
            if (File.Exists(soundFile))
            {
                byte[] soundFileByte = File.ReadAllBytes(soundFile);

                string query = "INSERT INTO Sounds (FileName, SoundFile) VALUES (@FileName, @SoundFile)";

                using (SQLiteConnection connection = new SQLiteConnection(ConnStringHelper.GetConn()))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FileName", fileName);
                        command.Parameters.AddWithValue("@SoundFile", soundFileByte);
                        command.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                Console.WriteLine("File tidak ditemukan: " + soundFile);
            }
        }
        #endregion

        #region file sound
        public List<string> GetSounds()
        {
            List<string> soundsList = new List<string>();

            string query = "SELECT FileName, SoundFile FROM Sounds";

            using (SQLiteConnection connection = new SQLiteConnection(ConnStringHelper.GetConn()))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string fileName = reader["FileName"].ToString();
                            string filePath = reader["FilePath"].ToString();
                            soundsList.Add($"{fileName} - {filePath}"); // Gabungkan nama file dan path
                        }
                    }
                }
            }

            return soundsList;
        }
        #endregion 

        public void PlaySoundFromDatabase(int soundId)
        {
            using (var Conn = new SQLiteConnection(ConnStringHelper.GetConn()))
            {
                Conn.Open();
                string query = @"SELECT SoundFile FROM Sounds WHERE SoundID = @SoundID";
                using (var cmd = new SQLiteCommand(query, Conn))
                {
                    cmd.Parameters.AddWithValue("@SoundID", soundId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            byte[] fileData = (byte[])reader["SoundFile"];
                            var memori = new MemoryStream(fileData);

                            _mp3FileReader = new Mp3FileReader(memori);
                            _waveOutEvent = new WaveOutEvent();


                            _waveOutEvent.Init(_mp3FileReader);
                            _waveOutEvent.Play();
                        }
                    }

                }
            }
        }


    }
}


