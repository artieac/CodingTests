package com.acorrea.hubspot.DomainModel;

import java.util.*;

/**
 * Created by acorrea on 1/30/2018.
 */
public class Partner
{
    private String firstName;
    private String lastName;
    private String email;
    private String country;
    private List<Date> availableDates;

    public Partner() {
        availableDates = new ArrayList<Date>();
    }

    public String getFirstName() { return this.firstName;}
    public void setFirstName(String value) { this.firstName = firstName; }

    public String getLastName() { return this.lastName;}
    public void setLastName(String value) { this.lastName = value;}

    public String getEmail() { return this.email;}
    public void setEmail(String value) { this.email = value;}

    public String getCountry() { return this.country;}
    public void setCountry(String value) { this.country = value;}

    public List<Date> getAvailableDates() { return this.availableDates; }
    public void setAvailableDates(List<Date> value) { this.availableDates = value;}

    public Set<Date> getPossibleEventDates()
    {
        Collections.sort(this.availableDates);

        Set<Date> retVal = new TreeSet<Date>();

        for(int i = 0; i < this.availableDates.size() - 1; i++)
        {
            Date currentDate = this.availableDates.get(i);
            Date nextDate = this.availableDates.get(i + 1);

            long dateDifference = nextDate.getTime() - currentDate.getTime();
            long numberOfDays = dateDifference / (24 * 60 * 60 * 1000);

            if(numberOfDays == 1)
            {
                // its two conesecutive days
                retVal.add(currentDate);
            }
        }

        return retVal;
    }
}
