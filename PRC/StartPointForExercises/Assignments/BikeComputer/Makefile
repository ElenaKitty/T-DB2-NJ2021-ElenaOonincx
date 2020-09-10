NAME=main

FILES=main.c

CC=gcc

SYMBOLS=-g -O0 -std=c99 -Wall -Werror -Wextra -pedantic -Wno-unused-parameter

.PHONY: clean

all: product

product: Makefile $(FILES)
	$(CC) $(INC_DIRS) $(SYMBOLS) $(FILES) -o $(NAME)

run: product
	./$(NAME)

clean:
	rm -f $(NAME)
