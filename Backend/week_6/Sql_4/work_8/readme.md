# Aşağıdaki sorgu senaryolarını test veri tabanı üzerinden gerçekleştiriyoruz.
Bu pratiğin tamamını readme.md dosyasından kontrol edebilirsiniz. 


## 1- test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.
```sql
CREATE TABLE employee (
    id SERIAL PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    birthdate DATE,
    email VARCHAR(100)
);
```
Bu linke tıklayarak test örnek veri tabanının 1. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_1.csv)



## 2- Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.
```sql
insert into employee (id, name, birthdate, email) values (1, 'Carma', '2024-04-14', 'clowes0@constantcontact.com');
insert into employee (id, name, birthdate, email) values (2, 'Kaia', '2024-04-10', 'krannigan1@eepurl.com');
insert into employee (id, name, birthdate, email) values (3, 'Welsh', '2024-06-09', 'wconquest2@washingtonpost.com');
insert into employee (id, name, birthdate, email) values (4, 'Nap', '2024-04-28', 'ngymlett3@ihg.com');
insert into employee (id, name, birthdate, email) values (5, 'Jonah', '2024-01-28', 'jglennard4@wordpress.com');
insert into employee (id, name, birthdate, email) values (6, 'Kevyn', '2024-10-10', 'kboughen5@gmpg.org');
insert into employee (id, name, birthdate, email) values (7, 'Rutger', '2024-09-23', 'rjasiak6@yellowpages.com');
insert into employee (id, name, birthdate, email) values (8, 'Friederike', '2024-02-16', 'fcroxall7@businesswire.com');
insert into employee (id, name, birthdate, email) values (9, 'Rickie', '2024-06-20', 'rfritche8@shareasale.com');
insert into employee (id, name, birthdate, email) values (10, 'Meriel', '2024-01-28', 'mgossage9@sun.com');
insert into employee (id, name, birthdate, email) values (11, 'Jeremy', '2024-04-10', 'jvoelkera@shop-pro.jp');
insert into employee (id, name, birthdate, email) values (12, 'Filia', '2024-12-08', 'fsadgroveb@diigo.com');
insert into employee (id, name, birthdate, email) values (13, 'Griffin', '2024-10-04', 'gbertomieuc@biglobe.ne.jp');
insert into employee (id, name, birthdate, email) values (14, 'Selby', '2024-07-07', 'sthirlwelld@instagram.com');
insert into employee (id, name, birthdate, email) values (15, 'Erika', '2024-02-22', 'ekenwarde@cnet.com');
insert into employee (id, name, birthdate, email) values (16, 'Sanson', '2024-09-01', 'sbeedlef@usgs.gov');
insert into employee (id, name, birthdate, email) values (17, 'Neala', '2024-06-05', 'nmackimg@opensource.org');
insert into employee (id, name, birthdate, email) values (18, 'Leanor', '2024-08-01', 'llatterh@tamu.edu');
insert into employee (id, name, birthdate, email) values (19, 'Winni', '2024-08-12', 'wpeterffyi@time.com');
insert into employee (id, name, birthdate, email) values (20, 'Evey', '2024-12-20', 'esammonsj@time.com');
insert into employee (id, name, birthdate, email) values (21, 'Leonanie', '2024-12-15', 'lmiskink@pinterest.com');
insert into employee (id, name, birthdate, email) values (22, 'Annette', '2024-05-15', 'awhettletonl@sciencedirect.com');
insert into employee (id, name, birthdate, email) values (23, 'Saundra', '2025-01-03', 'sstaddonm@yandex.ru');
insert into employee (id, name, birthdate, email) values (24, 'Adamo', '2024-04-02', 'abunningn@live.com');
insert into employee (id, name, birthdate, email) values (25, 'Cristionna', '2024-04-30', 'cbabidgeo@google.com.br');
insert into employee (id, name, birthdate, email) values (26, 'Eugenia', '2024-04-23', 'ebellep@rambler.ru');
insert into employee (id, name, birthdate, email) values (27, 'Neile', '2024-02-01', 'nniezenq@networkadvertising.org');
insert into employee (id, name, birthdate, email) values (28, 'Waiter', '2024-07-04', 'wpottager@dropbox.com');
insert into employee (id, name, birthdate, email) values (29, 'Glenda', '2024-02-12', 'gzanellis@tinypic.com');
insert into employee (id, name, birthdate, email) values (30, 'Brewster', '2024-03-02', 'bscholcroftt@is.gd');
insert into employee (id, name, birthdate, email) values (31, 'Corrie', '2024-02-15', 'cdaniellotu@ucla.edu');
insert into employee (id, name, birthdate, email) values (32, 'Rosalind', '2024-06-11', 'rpepperrallv@digg.com');
insert into employee (id, name, birthdate, email) values (33, 'Ariela', '2024-06-12', 'aknipew@vistaprint.com');
insert into employee (id, name, birthdate, email) values (34, 'Darice', '2024-11-02', 'dnewportx@webs.com');
insert into employee (id, name, birthdate, email) values (35, 'Heidie', '2024-06-15', 'hcaigy@google.es');
insert into employee (id, name, birthdate, email) values (36, 'Stevena', '2024-06-22', 'sdrinkhallz@bluehost.com');
insert into employee (id, name, birthdate, email) values (37, 'Alicia', '2024-02-12', 'abeams10@163.com');
insert into employee (id, name, birthdate, email) values (38, 'Consuela', '2024-12-09', 'csteinham11@about.me');
insert into employee (id, name, birthdate, email) values (39, 'Ammamaria', '2024-10-14', 'alorinez12@apple.com');
insert into employee (id, name, birthdate, email) values (40, 'Casandra', '2025-01-15', 'ckunisch13@parallels.com');
insert into employee (id, name, birthdate, email) values (41, 'Free', '2024-08-18', 'fcail14@utexas.edu');
insert into employee (id, name, birthdate, email) values (42, 'Sean', '2024-08-17', 'sdaintry15@bloomberg.com');
insert into employee (id, name, birthdate, email) values (43, 'Benedikta', '2024-10-30', 'bphillott16@mapy.cz');
insert into employee (id, name, birthdate, email) values (44, 'Blake', '2024-04-15', 'byanez17@moonfruit.com');
insert into employee (id, name, birthdate, email) values (45, 'Dalis', '2024-10-24', 'dmackinnon18@springer.com');
insert into employee (id, name, birthdate, email) values (46, 'Eddy', '2024-08-03', 'equinnelly19@google.it');
insert into employee (id, name, birthdate, email) values (47, 'Judy', '2024-07-21', 'jwoodgate1a@prlog.org');
insert into employee (id, name, birthdate, email) values (48, 'Jim', '2024-02-29', 'jhaskett1b@cdc.gov');
insert into employee (id, name, birthdate, email) values (49, 'Jase', '2024-09-30', 'jbenford1c@berkeley.edu');
insert into employee (id, name, birthdate, email) values (50, 'Stanly', '2024-07-15', 'sspohrmann1d@furl.net');
```
Bu linke tıklayarak test örnek veri tabanının 2. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_2.csv)




## 3- Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.
```sql
-- 1
UPDATE employee
SET name = 'Melih',
birthdate = '2001-07-14',
email = 'melihcan@gmail.com'
WHERE id = 1;
```
Bu linke tıklayarak test örnek veri tabanının 3. seneryoyada 1 adet yapılan UPDATE karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_3.csv)





## 4- Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.
```sql
DELETE FROM employee
WHERE id = 5
```
Bu linke tıklayarak test örnek veri tabanının 4. seneryoyada 1 adet yapılan DELETE sonucu silinen satır karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_4.csv)