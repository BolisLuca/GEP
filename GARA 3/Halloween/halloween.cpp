/*
 * This template is valid both in C and in C++,
 * so you can expand it with code from both languages.
 * NOTE: it is recommended to use this even if you don't
 * understand the following code.
 */

#include <stdio.h>
#include <assert.h>

// constraints
#define MAXN 100000

// input data
int N, i;
int C[MAXN];
long long int M;

int main() {
//  uncomment the following lines if you want to read/write from files
  freopen("input.txt", "r", stdin);
  freopen("output.txt", "w", stdout);

    assert(2 == scanf("%d %lld", &N, &M));
    for(i=0; i<N; i++)
        assert(1 == scanf("%d", &C[i]));

    // insert your code here
    bool diverso_da_uno = false;
    
    for(i=0; i < N;i++){
    	if(C[i] != 1) diverso_da_uno = true;
	}
	
	if(diverso_da_uno == true){
		
	
    do{
    	
	if(i==N){
		i=0;
	}
		M = M-C[i];	
		i++;
	}while(M>0);
}else{
	if(N == 2){
		if(M%2 == 0){
			i= 0;
		}else{
			i=1;
		}
	}else{
	i= N%M;
	}
	
}
	
   
    
    
    printf("%d\n",i); // print the result
    return 0;
}
