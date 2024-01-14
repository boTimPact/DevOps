# Assignment 7 - Kubernetes hosting

### Local
|   |   |
|:-:|---|  
|Benefits:| Full control over hardware, software and data. Independence and Customization. |
|Tradeoffs:| High initial costs. You need your own Server(s) and have to maintain them. Overcome complexeties. Need for a huge Team. |
|Costs:| Costs for Servers, Energy, Internet, Maintainace, Security, etc. In general higher then other solutions. |
|Limitations:| You are most likly bound to a specific location. |
|Risks and security:| Laws might permit you from going for another solution due to data Security. You need to ensure security standards. Critical customer data stays inhouse (maybe good or bad). |
|Maintenance:| You have to keep your Servers up to date. If a Server fails or needs an update you might not be able to handle incoming traffic. No customer support that can help you to get your cluster up and running. |
|Cluster creation:| You have to create the cluster yourself. |
|Scaling:| Limited scalability due to the fact that you need to purchase additional hardware. In times of low traffic your server infrastucture might be overkill. |
|CI/CD systems:| You have to take care of it yourself. |
|When to use:| When active in the healthcare sector or infrastucture is already onsite. |


### Self-managed

|   |   |
|:-:|---| 
|Benefits:| Control over software and data. Easily upgradeable hardware. No need for your own data center and a team to maintain it. You can focus on your product without worrying about infrastructure. |
|Tradeoffs:| You rely on the job and expertise regarding your hardware and infrastructure. Not location bound. |
|Costs:| Pay for hardware even if not used to full capacity. |
|Limitations:| Dependency on a provider. |
|Risks and security:| No direct control may lead to vulnerabilities. Laws may change, making this option unviable. Security can be improved as the provider can deploy experts more easily. A system on a local network could be more secure. |
|Maintenance:| Compatibility issues with hardware or software. |
|Cluster creation:| You have to create the cluster yourself. |
|Scaling:| Not as flexible as a cloud provider but more then local hosting. Vertical and horizontal scaling possible. |
|CI/CD systems:| You have to take care of it yourself. |
|When to use:| Anybody who has no capacity for a data warehouse, does not have to abide to laws. |


### Cloud provider

|   |   |
|:-:|---| 
|Benefits:| High flexibility. High availability. No provisioning. Infrastructure and services are provided. |
|Tradeoffs:| Huge dependency on a provider may have implications in the furure. |
|Costs:| Different payment models. You pay for the processing capacity you use so that unused capacity is not charged. |
|Limitations:| Data security laws can be an issue. |
|Risks and security:| You may get locked in a language, interface or program.  |
|Maintenance:| Infrastructure ist maintained by the provider. |
|Cluster creation:| A cluster can be immediately available. |
|Scaling:| Great scaling up and down. Primarily horizontal scaling. |
|CI/CD systems:| Some providers come with a solution for CI/CD integration. |
|When to use:| Great for small businesses and startups. |

<hr>

#### Sources

- My experience
- [dreamfactory.com](https://blog.dreamfactory.com/the-pros-and-cons-of-self-hosted-software-solutions/)  
- [tudelft.nl](https://www.tudelft.nl/teaching-support/faq/educational-tooling/what-are-the-risks-of-using-self-hosted-open-source-tools)  
- [openproject.org](https://www.openproject.org/de/blog/why-self-hosting-software/)  
- [avataracloud.com/](https://avataracloud.com/the-pros-and-cons-of-paas/)  
- [comptia.org - IaaS](https://www.comptia.org/content/articles/what-is-iaas)  
- [comptia.org - PaaS](https://www.comptia.org/content/articles/what-is-paas)  
- [star-knowledge.com](https://star-knowledge.com/blog/what-is-iaas-advantages-and-disadvantages/) 
- [aws.amazon.com - CI/CD](https://aws.amazon.com/de/getting-started/projects/set-up-ci-cd-pipeline/)  
- [aws.amazon.com - Pricing](https://aws.amazon.com/de/ec2/pricing/)

<hr>
