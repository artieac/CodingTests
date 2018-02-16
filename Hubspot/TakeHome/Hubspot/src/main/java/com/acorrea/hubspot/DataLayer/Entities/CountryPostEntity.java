package com.acorrea.hubspot.DataLayer.Entities;

import com.acorrea.hubspot.DomainModel.Invitation;
import com.fasterxml.jackson.annotation.JsonProperty;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by acorrea on 1/30/2018.
 */
public class CountryPostEntity
{
    List<InvitationPostEntity> invitations;

    public CountryPostEntity() {}

    public CountryPostEntity(List<Invitation> invitationsToAdd)
    {
        this.invitations = new ArrayList<InvitationPostEntity>();

        for(int i = 0; i < invitationsToAdd.size(); i++)
        {
            this.invitations.add(new InvitationPostEntity(invitationsToAdd.get(i)));
        }
    }

    @JsonProperty("countries")
    public List<InvitationPostEntity> getInvitations() { return this.invitations;}
    @JsonProperty("countries")
    public void setInvitations(List<InvitationPostEntity> value) { this.invitations = value;}
}
