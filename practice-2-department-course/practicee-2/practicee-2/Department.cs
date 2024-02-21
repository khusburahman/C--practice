namespace practicee_2;

 class Department
{
    public Department() {

        courses = new List<Course>();
    }
    public string Code { get; set; }
    public string Name { get; set; }    
    public List<Course> courses { get; set; }

    public string GetInfo()
    {
        string Info = "code:"+Code+"Name:"+Name+Environment.NewLine;
        foreach (Course course in courses)
        {
           Info +=course.GetInfo()+"\n"; 
        }
        return Info;
    }
}
