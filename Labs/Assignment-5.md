## Assignment 5 - Github Actions

### Approach

1. I started by creating my action that builds a Docker image on a push. 
2. After I got that to work I tried to reuse that action in another action that triggers on a pull to the main branch. Unfortunately I didn't get that to work because I was unable to pass the image to the next step.
3. So instead of reusing the first action I just copied the steps into to second action.

### Outcome

Both actions work as required (as far as I was able to test it). With more effort I might have been able to get my second approach step to work.
<hr>