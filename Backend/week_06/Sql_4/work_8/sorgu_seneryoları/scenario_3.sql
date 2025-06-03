-- Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.
-- 1
UPDATE employee
SET name = 'Melih',
birthdate = '2001-07-14',
email = 'melihcan@gmail.com'
WHERE id = 1;