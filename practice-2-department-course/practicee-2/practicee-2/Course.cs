

namespace practicee_2;

 class Course
{
    public string Code { get; set; }
    public  string Tittle {  get; set; }
    public double Credit { get; set; }

    public string GetInfo()
    {
        return "Course code: " + Code + "Tittle:" + Tittle + "Credit:" + Credit;
    }
    public int GetResult()
    {
        int mid = 20;
        int final = 40;
        int result = mid + final;
    }
}
