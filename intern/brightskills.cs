namespace intern
{
    class Brightskills
    {
        string trainer, location;

        string [] assests = {"computerfacility","waterfacility","classrooms","labs","restroom"};
        string [] lab = {"firstfloor,secondfloor"};
        string [] batch = {"morningbatch","noonbatch","nightshift"};

        public Brightskills(){
            trainer="Kind Karthick";
            location="Theppakulam";
        }

        public string gettrainer(){
            return trainer;
        }

         public string getlocation(){
            return location;
        }
    }
}