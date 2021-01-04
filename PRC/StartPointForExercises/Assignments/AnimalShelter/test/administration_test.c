#include <string.h>

#include "administration.h"
#include "unity.h"
#include "resource_detector.h"

// I rather dislike keeping line numbers updated, so I made my own macro to ditch the line number
#define MY_RUN_TEST(func) RUN_TEST(func, 0)

void setUp(void)
{
    // This is run before EACH test
}
void addAnimalTest(void)
{
    //prepare
    int arrayLength = 3;
    Animal animalArray[arrayLength];
    Animal parrot = { 1, Parrot, Male, 12, {1, 2, 2020}};
    size_t currentAnimals = 0;
    size_t newAnimals = 0;
    int expected = 0;
    //act
    int result = addAnimal(&parrot,animalArray,arrayLength,currentAnimals,&newAnimals);

    //assert
    TEST_ASSERT_EQUAL(1,newAnimals);
    TEST_ASSERT_EQUAL(expected, result);
}
void removeAnimalTest(void)
{
    //prepare
    int arrayLength = 3;
    Animal animalArray[arrayLength];
    Animal parrot = { 1, Parrot, Male, 12, {1, 2, 2020}};
    Animal dog = { 2, Dog, Male, 12, {1, 2, 2020}};
    size_t newAnimals = 0;
    size_t currentAnimals = 0;
    addAnimal(&parrot,animalArray,arrayLength,currentAnimals,&newAnimals);
    addAnimal(&dog,animalArray,arrayLength,currentAnimals,&newAnimals);

    //act
    int removedAnimals = removeAnimal(2, animalArray, 2, &newAnimals);

    //assert
    TEST_ASSERT_EQUAL(1, removedAnimals);
}
void findAnimalTest(void)
{
    //prepare
    int arrayLength = 3;
    Animal animalArray[arrayLength];
    Animal parrot = { 1, Parrot, Male, 12, {1, 2, 2020}};
    size_t currentAnimals = 0;
    size_t newAnimals = 0;
    addAnimal(&parrot,animalArray,arrayLength,currentAnimals,&newAnimals);
    int expected = 1;

    //act
    int result = findAnimalById(1,animalArray,1,&parrot);
    //assert
    TEST_ASSERT_EQUAL(expected, result);
}

void tearDown(void)
{
    // This is run after EACH test
}
int main (int argc, char * argv[])
{
    UnityBegin();

    MY_RUN_TEST(addAnimalTest);
    MY_RUN_TEST(removeAnimalTest);
    MY_RUN_TEST(findAnimalTest);

    return UnityEnd();
}
