namespace Hahn.ApplicationProcess.December2020.Service.Command
{
    public class UpdateApplicantCommand
    {
        public int Id { get;  set; }
        public string Name { get;  set; }
        public string Family { get;  set; }
        public string Address { get;  set; }
        public string CountryOfOrigin { get;  set; }
        public string EmailAddress { get;  set; }
        public int Age { get; set; }
        public bool Hired { get;  set; }
    }
}