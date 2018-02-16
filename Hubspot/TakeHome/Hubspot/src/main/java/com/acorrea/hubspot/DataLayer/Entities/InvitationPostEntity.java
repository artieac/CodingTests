package com.acorrea.hubspot.DataLayer.Entities;

import com.acorrea.hubspot.DomainModel.Invitation;
import com.fasterxml.jackson.annotation.JsonFormat;

import java.util.ArrayList;
import java.util.Date;
import java.util.List;

/**
 * Created by acorrea on 1/30/2018.
 */
public class InvitationPostEntity
{
    private String name;
    private Date startDate;
    private int attendedCount;
    private List<String> attendees;

    public InvitationPostEntity()
    {
        this.attendees = new ArrayList<String>();
    }

    public InvitationPostEntity(Invitation invitation)
    {
        this.setAttendedCount(invitation.getAttendeeCount());
        this.setAttendees(invitation.getAttendeeEmails());
        this.setName(invitation.getName());
        this.setStartDate(invitation.getStartDate());
    }

    public int getAttendeeCount() { return this.attendedCount;}
    public void setAttendedCount(int value) { this.attendedCount = value;}

    public List<String> getAttendees() { return this.attendees;}
    public void setAttendees(List<String> value) { this.attendees = value;}

    public String getName() { return this.name;}
    public void setName(String value) { this.name = value;}

    @JsonFormat(shape = JsonFormat.Shape.STRING, pattern = "yyyy-MM-dd")
    public Date getStartDate() { return this.startDate;}
    public void setStartDate(Date value) { this.startDate = value;}
}
