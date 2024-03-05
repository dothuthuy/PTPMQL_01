namespace NEWAPP.Model
{
    public class Employee
    {
public int manhanvien { get; set; }
public string Ten { get ;set; }
public int Tuoi { get; set; }
public int Luong { get; set; }
public int GetYearOfBirth(int Tuoi)
{
    int yearOfBirth = 2023 - Tuoi;
    return yearOfBirth;
}
    }
}
