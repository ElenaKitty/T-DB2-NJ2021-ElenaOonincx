ASSIGNMENT=fifo

UNITY_FOLDER=../../Unity
TEST_INC_DIRS=-I$(UNITY_FOLDER)

TEST_FILES=$(UNITY_FOLDER)/unity.c \
           $(ASSIGNMENT)_test.c \
           $(ASSIGNMENT).c

HEADER_FILES=*.h

TEST = $(ASSIGNMENT)_test

CC=gcc

SYMBOLS=-g -O0 -std=c99 -Wall -Werror -Wextra -pedantic -Wno-unused-parameter
TEST_SYMBOLS=$(SYMBOLS) -DTEST

.PHONY: clean test

all: $(TEST)

$(TEST): Makefile $(TEST_FILES)  $(HEADER_FILES)
	$(CC) $(TEST_INC_DIRS) $(TEST_SYMBOLS) $(TEST_FILES) -o $(TEST)

clean:
	rm -f $(TEST)

test: $(TEST)
	@./$(TEST)
