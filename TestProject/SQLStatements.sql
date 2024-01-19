/**
1. Query the NAME for all American cities in the CITY table with populations larger than
130,000. The CountryCode for America is USA.
**/
SELECT Name
FROM City
WHERE CountryCode = 'USA' AND Population > 130000;
/**
2. Query the NAME for the smallest city in Canada. The CountryCode for Canada is CN.
**/
SELECT Name
FROM City
WHERE CountryCode = 'CN'
ORDER BY Population
LIMIT 1;
/**
3. Find the total population of each country, including the number of cities and the total
population for each country.
**/
SELECT c.CountryCode, COUNT(c.Id) AS NumberOfCities, SUM(c.Population) AS TotalPopulation
FROM City c
GROUP BY c.CountryCode;
/**
4. Retrieve the top 3 cities with the highest population in the table, along with their
respective populations.
**/
SELECT
    Name, Population
FROM City
ORDER BY Population DESC
LIMIT 3;
/**
5. Find the city with the highest number of cars (CarAmount) and display its name.
**/
SELECT
    c.Name
FROM City c
JOIN CarAmount ca ON c.Id = ca.CityId
ORDER BY ca.Amount DESC
LIMIT 1;
/**
6. List the countries with more than 2 cities in the database.
**/
SELECT CountryCode, COUNT(Id) AS NumberOfCities
FROM City
GROUP BY CountryCode
HAVING COUNT(Id) > 2;
