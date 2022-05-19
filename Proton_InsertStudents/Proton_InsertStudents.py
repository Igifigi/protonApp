
import mysql.connector
from mysql.connector import errorcode
#region funcions and lists
"""
Warning! This code assumes that every female name and none male names end with a letter 'a'!
"""
def get_sex(name):
    char = name[len(name)-1]
    if char == 'a':
        return 0
    else:
        return 1
def get_class(c):
    if c == "I A":
        return 1
    if c == "I B":
        return 2
    if c == "I C":
        return 3
    if c == "I D":
        return 4
    if c == "I E":
        return 5
    if c == "II A":
        return 6
    if c == "II B":
        return 7
    if c == "II C":
        return 8
    if c == "II D":
        return 9
    if c == "II E":
        return 10
    if c == "III Ap":
        return 11
    if c == "III Bp":
        return 12
    if c == "III Cp":
        return 13
    if c == "III Dp":
        return 14
    if c == "III Ag":
        return 15
    if c == "III Bg":
        return 16
    if c == "III Cg":
        return 17
    if c == "III Dg":
        return 18
def print_list():
    for i in range(551):
        print(str(students[i].id) + " " + students[i].name + " " + students[i].surname + " " + str(students[i].class_id) + " " + str(students[i].sex))

names = ["NAME"]        # Insert names here
surnames = ["SURNAME"]  # Insert surnames here
classes = ["CLASS"]     # Insert classed here in format "X Y" where X stands for class number on a year and Y stands for class profile
                        # f.e. "I A" or "III Ap"
students = []
#endregion

class Student:
    def __init__(self, id, name, surname, class_id, sex):
        self.id = id
        self.name = name
        self.surname = surname
        self.class_id = class_id
        self.sex = sex

#region db
try:
    mydb = mysql.connector.connect( # Insert database info below
    host="",
    port='',
    user="",
    password="",
    database=''
    )
except mysql.connector.Error as err:
    print(err)
    quit()
c = mydb.cursor()
#endregion

def main():
    student_count = 0 # Insert here number of students
    id = 0
    for name in names:
        students.append(Student(id + 1, names[id], surnames[id], get_class(classes[id]), get_sex(names[id])))
        id += 1
    for i in range(student_count):
        try:
            value = (students[i].name, students[i].surname, students[i].class_id, students[i].sex)
            query = "INSERT INTO uczniowie (Imie, Nazwisko, Klasa_Id, Plec) VALUES (%s,%s,%s,%s)"
            c.execute(query, value)
        except mysql.connector.Error as err:
            print(err)
    mydb.commit()
    
if __name__ == "__main__":
    main()

