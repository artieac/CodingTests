package com.acorrea.hubspot.DomainModel;

import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.annotation.JsonProperty;

import java.util.ArrayList;
import java.util.Date;
import java.util.List;

/**
 * Created by acorrea on 1/30/2018.
 */
public class Invitation
{
    private String name;
    private Date startDate;
    private List<Partner> attendees;

    public Invitation(String countryIdentifier)
    {
        this.name = countryIdentifier;
        this.attendees = new ArrayList<Partner>();
    }

    public int getAttendeeCount() { return this.attendees.size();}

    @JsonIgnore
    public List<Partner> getAttendees() { return this.attendees;}
    public void setAttendees(List<Partner> value) { this.attendees = value;}

    @JsonProperty("attendees")
    public List<String> getAttendeeEmails()
    {
        List<String> retVal = new ArrayList<String>();

        for(int i = 0; i < attendees.size(); i++)
        {
            retVal.add(attendees.get(i).getEmail());
        }

        return retVal;
    }

    public void addAttendee(Partner newAttendee)
    {
        this.attendees.add(newAttendee);
    }

    public String getName() { return this.name;}
    public void setName(String value) { this.name = value;}

    public Date getStartDate() { return this.startDate;}
    public void setStartDate(Date value) { this.startDate = value;}
}
