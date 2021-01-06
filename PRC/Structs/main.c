#include <stdio.h>
#include <time.h>
#include <stdlib.h>


typedef struct
{
	int     StudentNumber;
	int     StudyCredits;
} STUDENT;

STUDENT students[10];

int main(void)
{
    srand(time(NULL));   // Initialization, should only be called once.

    for(int i = 0; i < sizeof(students) / sizeof(*students); i++)
    {
        STUDENT student;
        int n = rand() % 100; 
        student.StudentNumber = n;
        int c = rand() % 1000;
        student.StudyCredits = c;

        students[i] = student;
    }
    int totalCredits = 0;
    for(int i = 0 ; i < sizeof(students) / sizeof(*students); i++)
    {
        printf("Student %d is %d and has a credit of %d \r\n", i, students[i].StudentNumber, students[i].StudyCredits);
        totalCredits += students[i].StudyCredits;
    }
    printf("Total studyCredits is: %d \r\n", totalCredits);
    double averageCredits = totalCredits / (sizeof(students) / sizeof(*students));
    printf("Averate studyCredits is: %g ", averageCredits);
}

