## Assignment 8 - Kubernetes-deployments

### Approach

1. As I am very interested in this topic, I have decided to create my own small cluster with [`K3S`](https://docs.k3s.io/). 

2. I have created and provisioned 2 virtual machines for this purpose. 
3. I used this command: `curl -sfL https://get.k3s.io | K3S_KUBEKONFIG_MODE=644 sh -s` to initiallize my main node with the control plane.
4. This provided me with a token i could use to create a worker node by using this command: `curl -sfL https://get.k3s.io | K3S_TOKEN=[Token] K3S_URL="https://[Ip]:6443" K3S_NODE_NAME=[Name] sh -s`.
5. After I got my cluster up and running I created my kubernetes manifest files.
6. I started with Postgres for which I used a `stateful set` because a database is a stateful application. I had some problems mounting the persistence volume to it scince the documentation for kubernetes is a little confusing. In addition I created the `service`.
7. To create my database I had to provide some secrets which i applied using a secret.yaml.
8. Lastly I had to get my webservice up. Here I choose a `deployment`. The manifest was pretty straight forward but my containers were always crashing.
9. After checking the pod logs i found that my application wanted to connect to the database on startup. Unfortunately this failed constantly.
10. After much trial and error I discovered my mistake. I had configured my connection string in the same way I did in the `docker-compose` file. So my application tried to connect to the database directly. After I used the database service in the connection string and configured an external port everything worked as expected.
11. Finally I tried to replicate this with `Minikube` and it worked. All pods were created but I after using `minikube service <service-name>` I wasn't able to connect to my webservice.

### Outcome

After some huge difficulties getting my `K3S` cluster up I was able to get it to work. Since the documentation of Kubernetes was very confusing for me, I helped myself with Youtube. This helped me a lot to create the manifest files. Nevertheless I had problems with connecting and mounting the pods. In the end I managed to deploy my web service with Kubernetes.

<hr>
