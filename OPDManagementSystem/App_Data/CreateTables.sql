create table Doctors(id int primary key, name varchar, contact varchar)
create table Patient(id int primary key, name varchar, contact varchar, age int, gender varchar)
create table medicine_list(id int primary key, name varchar)
create table patient_consultation(id int primary key,consultation_date datetime, previous_consultation_id int, Diagnosis varchar)
create table patient_consultation_medicine(id int primary key,
medicine_id int not null references medicine_list(id), 
consultation_id int not null references patient_consultation(id), 
frequency varchar)