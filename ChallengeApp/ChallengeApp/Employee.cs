namespace ChallengeApp
{
    class Employee
    {
        private List<int> score = new List<int>();
        public Employee(string foreName, string surName, int age)
        {
            this.ForeName = foreName;
            this.SurName = surName;
            this.Age = age;
        }

        public string ForeName { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public int MaxGrade
        {
            get
            {
                return score.Max();
            }
        }
        public void AddScore(int number)
        {
            score.Add(number);
        }
    }
}
