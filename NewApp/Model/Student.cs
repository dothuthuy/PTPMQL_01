namespace NEWAPP.Model
{
    public class Student
    {
public string Hoten { get ;set; }
public int Tuoi { get; set; }
public string monhoc { get; set; }
public int GetYearOfBirth(int Tuoi)
{
    int yearOfBirth = 2023 - Tuoi;
    return yearOfBirth;
}
}
}


