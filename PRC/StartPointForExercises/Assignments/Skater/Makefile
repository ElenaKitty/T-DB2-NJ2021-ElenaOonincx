ASSIGNMENT=skater
SKATER_TEST=skater_test

UNITY_FOLDER=../../Unity
RESOURCE_CHECK_FOLDER=../../ResourceDetector
INC_DIRS=-I$(RESOURCE_CHECK_FOLDER) -Iproduct
TEST_INC_DIRS=$(INC_DIRS) -I$(UNITY_FOLDER)

SHARED_FILES=$(RESOURCE_CHECK_FOLDER)/resource_detector.c \
             $(RESOURCE_CHECK_FOLDER)/list.c \

ASSIGNMENT_FILES=$(SHARED_FILES) \
	             $(wildcard product/*.c)

SKATER_TEST_FILES=$(wildcard test/*.c) \
				   $(wildcard $(UNITY_FOLDER)/*.c) \
	               $(filter-out product/main.c, $(ASSIGNMENT_FILES)) \

HEADER_FILES=$(wildcard product/*.h) \

CC=gcc

SYMBOLS=-g -O0 -std=c99 -Wall -Werror -Wextra -pedantic -Wno-unused-parameter
TEST_SYMBOLS=$(SYMBOLS) -DTEST

.PHONY: all clean test

all: $(ASSIGNMENT)

$(ASSIGNMENT): Makefile $(ASSIGNMENT_FILES)  $(HEADER_FILES)
	$(CC) $(INC_DIRS) $(SYMBOLS) $(ASSIGNMENT_FILES) -o $(ASSIGNMENT)

$(SKATER_TEST): Makefile $(SKATER_TEST_FILES) $(HEADER_FILES)
	$(CC) $(TEST_INC_DIRS) $(TEST_SYMBOLS) $(SKATER_TEST_FILES) -o $(SKATER_TEST)

clean:
	@rm -f $(ASSIGNMENT) $(SKATER_TEST)

test: $(SKATER_TEST)
	@valgrind ./$(SKATER_TEST)
