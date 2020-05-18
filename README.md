# SEP6_CloudApplication
SEP6 Project Formulation 
 Deadline for hand-in:​ June 4th, 2020 at 13:00 (hand in on Wiseflow) Groups:​ You must be using your BPR1 groups for this project (if this is not possible, you must form a group of 2-4 students). Evaluation:​ The project is assessed solely on the written project which is assessed as either approved/not-approved. The evaluation is part of the overall evaluation of SEP6. Please see the course description for information about the other parts. 
 
Purpose The purpose is to examine the concept of Cloud Computing and the strategic considerations for using Cloud Computing.  
 
About the project The United Airplanes Association has hired you to create an application for them. The application will be used exclusively by a select few managers within the company. The managers need airport-related data readily available on their tablets, displayed through a web browser. The company is not interested in hosting the applications on their own premises. High uptime is essential, and the application must be available from anywhere with an internet connection and a web browser. 
 
Due to the above requirements, you will need to set up a cloud infrastructure. You decide what technology to use. That is, what cloud provider (Google, Microsoft, AWS, etc.) to utilize and what languages (Python, JavaScript, C#, Java, etc.) and frameworks to construct your web application in. 
 
The requirements of the SEP6 project are predefined. The main bulk of the work lies in you researching how to go about fulfilling the requirements, and subsequently implementing and writing about how you went about it. 
 The datasets are made available to you as .csv files. The datasets consist of the ny​cflights13 data which contains the ​airlines​, ​airports​, ​flights​, ​planes​, and ​weather​ datasets. Please see the documentation (​nycflights13.pdf​) for further information. 
 Functional requirements In what follows, “origin” refers to only JFK, EWR, and LGA. Apart from being able to load the flight data from the cloud, your system must be able to display/visualize: 
 
- Total number of flights per month - Total number of flights per month from the three origins in one plot. We want to be able to see - Frequency 
- Frequency stacked - Stacked percentage - The top-10 destinations and how many flights were made to these - For these 10 destinations, make a visualization of the number of flights from the three origins to the top-10 destination. - The mean airtime of each of the origins in a table - How many weather observations there are for the origins in a table - For each of the three origins, all temperature attributes in degree Celsius (i.e. you need to convert from Fahrenheit to Celsius) - The temperature (in Celsius) at JFK. - The daily mean temperature (in Celsius) at JFK - The daily mean temperature (in Celsius) for each origin in the same plot - Mean departure and arrival delay for each origin in a table - The manufacturers that have more than 200 planes - The number of flights each manufacturer with more than 200 planes are responsible for - The number of planes of each Airbus Model 
 
In the attached “examples”, you can see suggestions of how some of the above requirements can be solved. 
 
Documentation For this project you will only produce one report (i.e. there is no process report). The report must be 10-15 normal pages (2400 characters per page). Each figure/image/table counts as 600 characters. 
 
Besides the normal project report requirements, your report must include sections documenting how you manage and work with the DevOps tools of your choice. This includes explaining how you have set up your cloud provider, project management, version control, testing, etc., and if you have automated parts of your workflow through CI/CD. 
 
Your project report hand-in must contain a link to your working application, hosted by your cloud provider.
