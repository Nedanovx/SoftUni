# Task 1

You are given some **interfaces**, and you have to **implement** their functionality in the **correct classes**.
There are **3** types of entities: **Peak, BaseCamp, and Climber**. There should also be a **PeakRepository and ClimberRepository**.

**Peak**

**Data**
- **Name - string** 
    - If the name is **null or whitespace**, throw a new **ArgumentException** with the following message:</br> 
**"Peak name cannot be null or whitespace."**
- **Elevation - int**
    - Represents the **elevation of the specific** peak in meters.
    - Must be a **positive value**. If not, throw a new **ArgumentException** with the message: "Peak elevation must be a positive value."
- **DifficultyLevel – string**
    - Represents the level of difficulty to climb the specific peak. The property is allowed to accept the following options only:</br>
**"Extreme", "Hard" or "Moderate"**. This validation will occur in the AddPeak method in the Controller class. </br>

**Override ToString() method:**

Overrides the existing method ToString() and modify it, so the returned string must be on a single line, in the following format:</br>
**"Peak: {Name} -> Elevation: {Elevation}, Difficulty: {DifficultyLevel}"**

**Constructor**

A Peak should take the following values upon initialization:</br> 
string name, int elevation, string difficultyLevel

**Climber**

The Climber is a base class of any type of climber, and it should not be able to be instantiated.

**Data**
-	**Name - string**
    -	If the Name is null or whitespace, throw a new ArgumentException with the message:</br> 
**"Climber's name cannot be null or whitespace."**
-	**Stamina – int**
    -	The climber's stamina, in the mountains. Must be a value from 0 up to 10, both inclusive.
    -	If it exceeds 10 during any operation, it should be reset to 10.
    -	If it drops below zero during any operation, it should be reset to zero.
-	ConqueredPeaks – IReadOnlyCollection<string>
    -	It will store a sequence of names of peaks, conquered by a climber.

**Behavior**

**void Climb(IPeak peak)**

The method will add the given peakName to the collection of ConqueredPeaks, if the peak is already climbed by the specific climber,</br>
do NOT duplicate the peakName in the collection of ConqueredPeaks, but climber can climb a peak unlimited times. <br>
The method will always decrease the climber’s Stamina by:</br>
-	If the peak’s DifficultyLevel is "Extreme" - 6 units ;
-	If the peak’s DifficultyLevel is "Hard" - 4 units ;
-	If the peak’s DifficultyLevel is "Moderate" - 2 units ;

**void Rest(int daysCount)**

It should be an abstract method. The climber's Stamina should be recovered. For every day of resting the different types of climbers will recover a different amount of Stamina. The exact recovery rate for each day of rest will be defined in child classes.

**Override ToString() method:**
Overrides the existing method ToString() and modifies it, so the returned string is in the following format:</br>
**"{climberTypeName} - Name: {Name}, Stamina: {Stamina}**</br>
**Peaks conquered: no peaks conquered/{peaksCount}"**

HINT: The ToString() method should return output on two separate lines.

**Constructor**

A Climber should take the following values upon initialization:</br> 
string name, int stamina

**Child Classes**

There are two concrete types of Climber:

**OxygenClimber**

The OxygenClimber class represents climbers who use supplemental oxygen. They may have higher stamina but recover more slowly due to reliance on external oxygen sources.
-	Will be allowed to climb peaks with extreme difficulty level.
-	Will have an initial Stamina of 10 units.
-	Will recover 1 unit of Stamina for every day of rest in the base camp.

The Constructor of the OxygenClimber should take the following parameters upon initialization:</br>
string name

**NaturalClimber**
The NaturalClimber class is for climbers who climb without the aid of supplemental oxygen. They are acclimatized to high altitudes and can recover stamina more quickly, demonstrating greater natural adaptation to challenging environments.
-	Will NOT be allowed to climb peaks with extreme difficulty level.
-	Will have an initial Stamina of 6 units.
-	Will recover 2 units of Stamina for every day of rest in the base camp.

The Constructor of the NaturalClimber should take the following parameters upon initialization:</br>
string name

**BaseCamp**

**Data**
- **Residents – IReadOnlyCollection<string>**
    -	An alphabetically ordered collection of the names of all climbers currently staying in the base camp.

**Behavior**

**void ArriveAtCamp(string climberName)**

A method to record the arrival of a climber at the base camp. It adds the climber's name to the Residents collection.
void LeaveCamp(string climberName)
A method to record the climber’s leaving from the base camp. It removes the climber's name from the Residents collection.

**Constructor**

A BaseCamp will take no parameters upon initialization

**PeakRepository**

The PeakRepository is an IRepository<IPeak>. Collection for the peaks.

**Data**
- **All – IReadOnlyCollection<IPeak>**
    -	Returns a readonly collection of all peaks, added to the repository.

**Behavior**

**void Add(IPeak model)**
-	Adds a new IPeak to the PeakRepository.

**IPeak Get(string name)**
-	Returns a peak with the given name from the collection, if there is any. Otherwise, it returns null.

**ClimberRepository**

The ClimberRepository is an IRepository<IClimber>. Collection for the climbers.

**Data**
-**All – IReadOnlyCollection<IClimber>**
    -	Returns a readonly collection of all climbers, added to the repository.

**Behavior**

**void Add(IClimber model)**
-**Adds a new IClimber to the ClimberRepository**.

**IClimber Get(string name)**

Returns a climber with the given name from the collection, if there is any. Otherwise, it returns null.

# Task 2
**Data**

You need to keep track of some things, this is why you need some private fields in your controller class:

**Example:**
- **peaks - PeakRepository**
- **climbers – ClimberRepository**
- **baseCamp - BaseCamp**

**Commands**

There are several commands, which control the business logic of the application. They are stated below.

**AddPeak Command**

**Parameters**
- **name – string**
- **elevation – int**
- **difficultyLevel - string**

**Functionality**

The method should create and add a new IPeak to the PeakRepository.
-	If a peak with the given name is already added to the PeakRepository, it should NOT be duplicated. Return the following message:</br>
**"{name} is already added as a valid mountain destination."**
-	If the given difficulty level is NOT among one of the accepted values ("Extreme", "Hard" or "Moderate"), the peak should NOT be added and the following message should be returned:</br>
**"{difficultyLevel} peaks are not allowed for international climbers."**
-	If none of the above cases is reached, the IPeak is successfully created. Store the peak in the appropriate collection and return:</br>
**"{name} is allowed for international climbing. See details in {correctRepositoryTypeName}."**

**NewClimberAtCamp Command**

**Parameters**
-**name - string**
-**isOxygenUsed - bool**

**Functionality**

The method should create and add a new IClimber to the ClimberRepository and the name of the new climber to the base camp.
-	If a climber with the given name is already added to the ClimberRepository, it should NOT be duplicated. Return the following message:,/br>
**"{name} is a participant in {correctRepositoryTypeName} and cannot be duplicated."**
-	If the above case is not reached:
    -	The isOxygenUsed used parameter, represents whether the climber uses external source of oxygen, when climbing peaks.
    -	Pick the correct type of IClimber, depending on the isOxygenUsed parameter. Check the Climber child classes, and see which type uses supplemental oxygen and which does not.
    -	Create the correct type of IClimber and add it to the ClimberRepository and the baseCamp. Return the following message:</br>
**"{name} has arrived at the BaseCamp and will wait for the best conditions."**

**AttackPeak Command**

**Parameters**
-	**climberName - string**
-	**peakName – string**

**Functionality**

The method is responsible for allowing the specific climber to attempt to climb a specific peak:
-	Validates if a climber with the given climberName is at the ClimberRepository. If no climber with the provided name is found, return the following message:</br> **"Climber - {climberName}, has not arrived at the BaseCamp yet."**
-	Validates if a peak with the given peakName exists in the PeakRepository. If no peak with the provided name is found, return the following message:,/br>
**"{peakName} is not allowed for international climbing."**
-	BaseCamp  search - If a climber with the given climberName is NOT found in the base camp, the attack of the peak is postponed. Return the following message:</br>
**"{climberName} not found for gearing and instructions. The attack of {peakName} will be postponed."**
-	If the peak’s DifficultyLevel is "Extreme", but the climber is NaturalClimber, the climber will NOT be allowed to leave the baseCamp and start an attack. Return the following message:</br>
**"{climberName} does not cover the requirements for climbing {peakName}."**
-	The climber leaves the baseCamp (LeaveCamp() method) and attacks the peak:
    -	The climber will try to climb the peak, executing the Climb() method.
        -	If the climber’s Stamina drops to zero, the attack will NOT be successful. The climber will NOT return to the baseCamp. Return the following message:</br>
**"{climberName} did not return to BaseCamp."**
        -	If the climber’s Stamina doesn’t drop to zero, the attack will be successful. The climber will return to the basecamp (ArriveAtCamp() method). Return the following message:</br>
**"{climberName} successfully conquered {peakName} and returned to BaseCamp."**

**CampRecovery Command**

**Parameters**
-	**climberName - string**
-	**daysToRecover – int**

**Functionality**

The method allows a specified climber to recover his stamina over a given number of days. It focuses on climbers who are currently at the BaseCamp:
-	Check if a climber with the given climberName is presented at the base camp. If NOT, return the following message:</br>
**"{climberName} not found at the BaseCamp."**
-	If the climber’s Stamina is already at its maximum (10 units), he does not need further recovery. Return the following message:</br>
**"{climberName} has no need of recovery."**
-	If the climber requires recovery (Stamina less than 10), execute the climber's Rest() method based on the daysToRecover parameter. Return the following message:</br>
**"{climberName} has been recovering for {count} days and is ready to attack the mountain."**

**BaseCampReport Command**

**Functionality**

This method generates a report of the climbers currently at the BaseCamp, providing key details about each climber.
-	For each climber in the Residents collection retrieve detailed information about the climber from the ClimberRepository (Name, Stamina, Count of ConqueredPeaks):</br>
"BaseCamp residents:</br>
Name: {climber1Name}, Stamina: {Stamina}, Count of Conquered Peaks: {count}</br>
Name: {climber2Name}, Stamina: {Stamina}, Count of Conquered Peaks: {count}</br>
Name: {climber3Name}, Stamina: {Stamina}, Count of Conquered Peaks: {count}</br>
…</br>
Name: {climbernName}, Stamina: {Stamina}, Count of Conquered Peaks: {count}"</br>

-	If there are no climbers at the BaseCamp, return: "BaseCamp is currently empty."

**OverallStatistics Command**

**Functionality**

Returns information about each climber from the ClimberRepository. Arrange the climbers by the count of conquered peaks in descending order,  then by name - alphabetically. Arrange their peaks by Elevation in descending order. To receive the correct output, use the ToString() method of each climber and each climber’s conquered peak:</br>
**"\*\*\*Highway-To-Peak\*\*\***</br>
{climber1}</br>
{peak1}</br>
{peak2} </br>
…</br>
{peakn} </br>
{climber2}</br>
{peak1} </br>
{peak2} </br>
…</br>
{peakn} </br>
...</br>
{climbern}</br>
{peak1} </br>
{peak2} </br>
…</br>
{peakn} </br>
"</br>

NOTE: Do not use "\r\n" for a new line. </br>
**Exit Command**</br>
Functionality</br><
Ends the program.</br>

# Task 3
You will receive a skeleton with one class inside it. TelevisionDevice class will have some methods, fields, and constructors. Cover the whole class with the unit test to make sure that the class is working as intended. 
-	Do NOT CHANGE OR REMOVE ANY namespaces or usings. 
-	Do not use "\r\n" for a new line. 
