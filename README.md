## SQL Command

Create database bimbel_un. Then running this command for generate tables

```sql
CREATE TABLE login (
    id INT AUTO_INCREMENT PRIMARY KEY,
    email VARCHAR(100) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL
);

INSERT INTO login (email, password) VALUES ('admin@admin.com', 'admin');

CREATE TABLE guru (
  nama varchar(25) NOT NULL,
  nip varchar(20) NOT NULL,
  guru_mapel varchar(11) DEFAULT NULL
);

INSERT INTO guru (nama, nip, guru_mapel) VALUES
('LUKI MAHENDRA SAPUTRA', 'STI202303595', 'MATEMATIKA');

CREATE TABLE data_siswa (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nama VARCHAR(100) NOT NULL,
    nisn VARCHAR(15) NOT NULL UNIQUE,
    kelas VARCHAR(10) NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

CREATE TABLE kehadiran (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nama VARCHAR(255) NOT NULL,
    nip VARCHAR(50) NOT NULL,
    tanggal DATE DEFAULT CURRENT_DATE,
    keterangan VARCHAR(255) NOT NULL
);

CREATE TABLE nilai (
    id INT(100) AUTO_INCREMENT PRIMARY KEY,
    nama VARCHAR(100),
    nip VARCHAR(100),
    kelas VARCHAR(100),
    matematika DECIMAL(5,2),
    ipa DECIMAL(5,2),
    bahasa_indonesia DECIMAL(5,2)\
);
```