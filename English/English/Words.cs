namespace English
{
    [System.Runtime.Serialization.DataContractAttribute]
    public class Words
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        public string Eng { get; set; }

        [System.Runtime.Serialization.DataMemberAttribute]
        public string Rus { get; set; }

        [System.Runtime.Serialization.DataMemberAttribute]
        public int TimeToRemember { get; set; }

        [System.Runtime.Serialization.DataMemberAttribute]
        public int Step { get; set; }

        [System.Runtime.Serialization.DataMemberAttribute]
        public int eng_lrn_count { get; set; }

        [System.Runtime.Serialization.DataMemberAttribute]
        public int rus_lrn_count { get; set; }


        public Words(string eng, string rus, int timeToRemember, int step, int elc, int rlc)
        {
            Eng = eng;
            Rus = rus;
            TimeToRemember = timeToRemember;
            Step = step;
            eng_lrn_count = elc;
            rus_lrn_count = rlc;
        }
    }


}
