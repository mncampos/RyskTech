# RyskTech
This software is designed to aid the collection and categorization of information concering laboratories and general spaces that manipulate **chemical**, **biological**, **mechanical** and/or **physical** agents. This software is being developed for INF01022 Laboratório de Sistema de Software @ UFRGS Computer Sciences course, and also works as a basis for another group of students. 

## Base Funcionalities
The software is meant to act as a convenient and standardized way for laboratories to register their potentially dangerous agents and general safety practices/equipment. The software is separated into two sub-divisions: Laboratories and Units;
* Units are used in this context as a way to represent entities such as companies and institutes, which are usually formed of multiple spaces and/or laboratories.
* Laboratories represent the sub sections of units, often spacially in the same unit but occupying different spaces. Some examples of spaces could be common rooms such as warehouses, cleaning product closets, laboratories, etc.

Below are listed the base requirements for each of the two sub-divisions, and a third requirement for both.
### Unit
In the interest of dividing the workload between the unit's management team and the lab's responsible personnel the unit section is responsible for general information concerning the shared space. Information requested from the unit management team includes:
* Unit name, location and surrounding area information
* The type of agents present 
    * chemical, biological, mechanical and/or physical
* What rooms or spaces are used in the premisses 
* Unit director and vice-director contact information
* Unit's brief description and history
* Unit's considered analysis methodology, such as security specifications adhered to

### Laboratory
The laboratory manager (whoever is responsible for it's maintenance) will be asked to enter more specific information about the agents and security measures for that specific lab. Such information contains:
* A quick description of the containing unit and purpose of the laboratory
* The people responsible for the laboratory
* Type of agents used specifically on that laboratory or space
    * chemical, biological, mechanical and/or physical
* For each of the selected types of agent:
    * Listing of the agents (When applicable) with
        * Storage information)
        * Storage quantity 
        * Usage
        * Origin
        * Disposal method
    * Provided training and trainees
    * Compliance to national and international safety standards
    * Other information more specific to the agent type

### Potential environmental risk analysis document
Finally, with all the information that was gathered from the labs and/or units, the software must generate a document which contains all of the above information, formatted according to some standard to be defined. Either the software itself should send the document to a central point of analysis or the software must instruct the user where to send the document, once completed.

## Resources
Some resources for development are listed below
* Jamboard with interface requirements: https://jamboard.google.com/d/1yrfbC4A2FgMeFCsPLOxwW4NwteOtxSnUUdqXfzW54Uk/viewer