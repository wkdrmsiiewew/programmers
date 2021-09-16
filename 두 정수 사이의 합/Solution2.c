#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

long long solution(int a, int b) {
    if(a==b) return a;        
    int sum = a+b;
    int count = b-a+1;
    if(a>b) count = a-b+1;
    return (long long) sum*count/2;
    
}