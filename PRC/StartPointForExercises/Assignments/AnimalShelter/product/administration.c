#include "administration.h"

#include <stdbool.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// Note: make sure to set 'resource_detector.h' as the last include.
#include "resource_detector.h"

int addAnimal(const Animal *animalPtr, Animal *animalArray,size_t animalArrayLength, size_t numberOfAnimalsPresent,size_t *newNumberOfAnimalsPresent)
{
    if (animalPtr == NULL || animalArray == NULL)
    {
        return -1;
    }
    if (animalArrayLength > numberOfAnimalsPresent)
    {
        animalArray[numberOfAnimalsPresent] = *animalPtr;
        *newNumberOfAnimalsPresent = numberOfAnimalsPresent + 1;
        return 0;
    }
    return -1;
}

int removeAnimal(int animalId, Animal *animalArray,size_t numberOfAnimalsPresent,size_t *newNumberOfAnimalsPresent)
{
    //doesnt shrink the list of animals. but rather copies the one before it.
    if (animalArray == NULL)
    {
        return -1;
    }
    int removed = 0;
    for (size_t i = 0; i < numberOfAnimalsPresent; i++)
    {
        if (animalArray[i].Id == animalId)
        {
            animalArray[i] = animalArray[i + 1];
            removed = removed + 1;
        }
    }
    if (removed >= 0)
    {
        *newNumberOfAnimalsPresent = numberOfAnimalsPresent - removed;
        return removed;
    }
    else
    {
        return -1;
    }
}

int findAnimalById(
    int animalId, const Animal *animalArray,
    size_t numberOfAnimalsPresent, Animal *animalPtr)
{
    bool found = false;
    for (size_t i = 0; i < numberOfAnimalsPresent; i++)
    {
        if (animalArray[i].Id == animalId)
        {
            *animalPtr = animalArray[i];
            found = true;
            return 1;
        }
    }
    if (!found)
    {
        return 0;
    }
    else
    {
        return -1;
    }
}

/*-------------------------------------------------------------------------------*/
int sortAnimalsByAge(Animal *animalArray, size_t numberOfAnimalsPresent)
{
    return 0;
}

int sortAnimalsByYearFound(
    Animal *animalArray, size_t numberOfAnimalsPresent)
{
    return 0;
}

int sortAnimalsBySex(Animal *animalArray, size_t numberOfAnimalsPresent)
{
    return 0;
}
