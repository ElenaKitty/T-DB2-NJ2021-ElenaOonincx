#include <string.h>
#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int main (int argc, char * argv[])
{
		char Name[] = "Inspector Gadget";

		printf("Name = %s -> size = %d - %d\n", Name, (int)strlen(Name), (int)sizeof(Name));
		printf("%s\n",Name);
		printf("%s\n",&Name[0]);
		// what is printed??


		// looping through characters one by one
		int index = 0;
		while(Name[index]!='\0')
		{
			char current_char = Name[index];
			printf("%c", current_char);
			index++;
		}
		printf("\n");
		
		//what is printed next??
		char* ptr = Name;
		while (*ptr!='\0')
		{
			printf("%c", *ptr++); // some real c magic
		}
		printf("\n");

		char otherName[] = "Inspector";
		// there are many string handling functions in c
		printf("Compare %d\n", strcmp(Name, otherName));
		printf("Compare %d\n", strncmp(Name, otherName,9));

		Name[9] = '\0';
		printf("Name = %s -> size = %d\n", Name,(int)strlen(Name));
		printf("Compare %d\n", strcmp(Name, otherName));


		char yourName[] = "Frits";
		char* myName = "Frits";
		char* sameName = "Frits";
		char* friendsName = "Frank";

		if(yourName != myName) {
			printf("But our names are the same?\n");
			printf("Location of yourName: %p\n", yourName);
			printf("Location of myName: %p\n", myName);
			printf("Consider using <string.h>!\n");
		}

		if(myName == sameName) {
			printf("The pointers do point to the same address...\n");
			printf("Location of myName: %p\n", myName);
			printf("Location of sameName: %p\n", sameName);
		}

		if(*yourName == *myName) {
			printf("Finally something that works\n");
		}
		if(*yourName == *friendsName) {
			printf("This is really weird!? %s does not equal %s\n",yourName,friendsName);
		}


		return 0;
}
