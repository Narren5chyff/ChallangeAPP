﻿namespace ChallengeAPP
{
    public interface IEmploee
    {
        string Name { get; }
        string Surname { get; }
        string Sex { get; }

         void AddGrade(float grade);

         void AddGrade(string grade);

         void AddGrade(long grade);

         void AddGrade(double grade);

         Statistics GetStatisticsInForEach();

    }
}
