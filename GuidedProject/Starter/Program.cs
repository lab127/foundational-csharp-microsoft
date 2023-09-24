﻿int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentScores = new int[10];


Console.WriteLine("Student\t\tExam Score\tOveral\tGrade\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    else
        continue;

    decimal sumAssignmentScores = 0;
    int countExtras = 0;
    int countAssignments = 0;
    int sumExamScore = 0;
    int sumExtraScore = 0;
    foreach (int score in studentScores)
    {
        countAssignments++;
        // extra creadit condition
        if (countAssignments > examAssignments)
        {
            // extra bonus equal 10%
            sumAssignmentScores += (decimal)score / 10;
            sumExtraScore += score;
            countExtras++;
        }
        else
        {
            sumAssignmentScores += score;
            sumExamScore += score;
        }
    }

    decimal currentStudentGrade = 0;
    currentStudentGrade = sumAssignmentScores / examAssignments;

    decimal studentExamScores = 0;
    studentExamScores = (decimal)sumExamScore / examAssignments;

    int studentExtraScores = 0;
    studentExtraScores = sumExtraScore / countExtras;

    decimal studentExtraCreditPoints = 0;
    studentExtraCreditPoints = currentStudentGrade - studentExamScores;

    string currentStudentLetterGrade = "";
    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";
    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";
    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";
    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";
    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";
    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";
    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";
    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";
    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";
    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{studentExamScores}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{studentExtraScores} ({studentExtraCreditPoints})");
}


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();


