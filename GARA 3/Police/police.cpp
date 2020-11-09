/*
 * This template is valid both in C and in C++,
 * so you can expand it with code from both languages.
 * NOTE: it is recommended to use this even if you don't
 * understand the following code.
 */

#include <assert.h>
#include <stdio.h>

// constraints
#define MAXN 100000

// input data
int N, K, i, k=0;
int V[MAXN + 1], P[MAXN + 1];

int main() {
  //  uncomment the following lines if you want to read/write from files
      freopen("input.txt", "r", stdin);
  //  freopen("output.txt", "w", stdout);

  assert(2 == scanf("%d %d", &N, &K));
  for (i = 1; i <= N; i++) assert(1 == scanf("%d", &V[i]));

  // insert your code here
  for(i=0;i<N;i++){
  	if(i>0){
	  	k++;
	  }
  	if(i+1==K){
  		i=N;
	  }
	  else{
	  	i=V[i];
	  }
	  P[i]=V[i];
	  for(int j=0;j<N;j++){
	  	if(P[i]==i){
	  		k=-1;
	  		i=N;
		  }
	  }
	  }
	
  printf("%d\n", k);  // print the result
  return 0;
}
