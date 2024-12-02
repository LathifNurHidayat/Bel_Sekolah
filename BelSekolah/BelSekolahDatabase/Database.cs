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

        public void CreateTable()
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnStringHelper.GetConn()))
            {
                connection.Open();

                string createTableJadwalHari = @"
                    CREATE TABLE IF NOT EXISTS JadwalHari(
                        HariID INTEGER PRIMARY KEY AUTOINCREMENT,
                        JenisJadwal TEXT NOT NULL,
                        Hari TEXT NOT NULL
                    )";

                string addHariKosong = @"
                     WITH AllDays AS (
                            SELECT 'Senin' AS Hari UNION ALL
                            SELECT 'Selasa' UNION ALL
                            SELECT 'Rabu' UNION ALL
                            SELECT 'Kamis' UNION ALL
                            SELECT 'Jumat' UNION ALL
                            SELECT 'Sabtu' UNION ALL
                            SELECT 'Minggu'
                        )
                        INSERT INTO JadwalHari (JenisJadwal, Hari)
                        SELECT 'Jadwal Normal', AllDays.Hari
                        FROM AllDays
                        LEFT JOIN JadwalHari JH ON AllDays.Hari = JH.Hari
                        WHERE JH.Hari IS NULL";

                string createTableJadwalKhusus = @"
                    CREATE TABLE IF NOT EXISTS JadwalKhusus(
                        JadwalKhususID INTEGER PRIMARY KEY AUTOINCREMENT,
                        HariID INTEGER,
                        Waktu TEXT,
                        Keterangan TEXT,
                        SoundName TEXT,
                        SoundPath TEXT
                     )";

                string createTableJadwalNormal = @"
                    CREATE TABLE IF NOT EXISTS JadwalNormal(
                        JadwalNormalID INTEGER PRIMARY KEY AUTOINCREMENT,
                        HariID INTEGER NOT NULL,
                        Waktu TEXT ,
                        Keterangan TEXT,
                        SoundName TEXT,
                        SoundPath TEXT,

                        FOREIGN KEY (HariID) REFERENCES JadwalHari(HariID) ON DELETE CASCADE
                    )";

                ExecuteNonQuery(createTableJadwalHari, connection);
                ExecuteNonQuery(addHariKosong, connection);
                ExecuteNonQuery(createTableJadwalKhusus, connection);
                ExecuteNonQuery(createTableJadwalNormal, connection);

                void ExecuteNonQuery(string query, SQLiteConnection connection)
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}


