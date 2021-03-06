/*
 * This template is valid both in C and in C++,
 * so you can expand it with code from both languages.
 * NOTE: it is recommended to use this even if you don't
 * understand the following code.
 */

#include <stdio.h>
#include <assert.h>

// constraints
#define MAXN 1000000

// input data
int N, i;
int C[MAXN];

int main() {
//  uncomment the following lines if you want to read/write from files
  freopen("input.txt", "r", stdin);
  freopen("output.txt", "w", stdout);

    assert(1 == scanf("%d", &N));
    for(i=0; i<N; i++)
        assert(1 == scanf("%d", &C[i]));

    // insert your code here
    int max_scala = 0;
    
    for(i=0;i<N;i++){
    	if(i==0){
    		max_scala = C[i];
		}		else{
			if((C[i]-C[i-1])>max_scala){
				max_scala = C[i]-C[i-1];
			}
		}
	}
	
    printf("%d\n", max_scala); // print the result
    return 0;
}
