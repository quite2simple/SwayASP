namespace SwayASP.Models
{
    public static class PathfinderPlaceholder
    {
        public static string Path(Station a, Station b, ApplicationContext db)
        {
            string res = "Could not find path";
            string a_line = db.Lines.Single(x => x.Id == a.LineFK).Name;
            string b_line = db.Lines.Single(x => x.Id == b.LineFK).Name;
            if (a.Name == b.Name)
            {
                return a.Name;
            }
            if (a_line == "A")
            {
                if (b_line == "A")
                {
                    res = a.Name + " - " + b.Name;
                }
                else if (b_line == "B")
                {
                    res = a.Name + " - Lawson-A-B - " + b.Name;
                }
                else if (b_line == "C") 
                {
                    res = a.Name + " - Campion-A-C - " + b.Name;
                }
                else if (b_line == "D")
                {
                    res = a.Name + " - Lawson-A-B - Croft-B-D - " + b.Name;
                }
            }
            else if (a_line == "B")
            {
                if (b_line == "B")
                {
                    res = a.Name + " - " + b.Name;
                }
                else if (b_line == "C")
                {
                    res = a.Name + " - Barton-B-C - " + b.Name;
                }
                else if (b_line == "D") 
                {
                    res = a.Name + " - Croft-B-D - " + b.Name;
                }
            }
            else if (a_line == "C")
            {
                if (b_line == "C")
                {
                    res = a.Name + " - " + b.Name;
                }
                else if (b_line == "D")
                {
                    res = a.Name + " - Downtown-B-C - Croft-B-D - " + b.Name;
                }
            }
            return res;
        }
    }
}
