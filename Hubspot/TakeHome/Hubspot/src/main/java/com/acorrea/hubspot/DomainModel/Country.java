package com.acorrea.hubspot.DomainModel;

import java.util.*;

/**
 * Created by acorrea on 1/30/2018.
 */
public class Country
{
    String identifier;
    List<Partner> partners;

    public Country(String identifier)
    {
        this.identifier = identifier;
    }
    public String getIdentifier() { return this.identifier;}

    public List<Partner> getPartners() { return this.partners;}

    public void addPartner(Partner partner)
    {
        if(this.partners == null)
        {
            this.partners = new ArrayList<Partner>();
        }

        if(this.identifier.equals(partner.getCountry()))
        {
            this.partners.add(partner);
        }
    }

    private Map<Date, List<Partner>> getAttendeesByDate()
    {
        Map<Date, List<Partner>> retVal = new TreeMap<Date, List<Partner>>();
        Set<Date> allPossibleDates = new TreeSet<Date>();

        for (Partner countryPartner : this.getPartners())
        {
            allPossibleDates.addAll(countryPartner.getPossibleEventDates());
        }

        for(Partner currentPartner : this.getPartners())
        {
            Set<Date> partnerDates = currentPartner.getPossibleEventDates();

            for (Date partnerDate : partnerDates)
            {
                if (allPossibleDates.contains(partnerDate))
                {
                    List<Partner> matchingPartners;

                    if (retVal.containsKey(partnerDate))
                    {
                        matchingPartners = retVal.get(partnerDate);
                    }
                    else
                    {
                        matchingPartners = new ArrayList<Partner>();
                    }

                    matchingPartners.add(currentPartner);
                    retVal.put(partnerDate, matchingPartners);
                }
            }
        }

        return retVal;
    }

    public Invitation findInvitationDate()
    {
        Invitation retVal = new Invitation(this.getIdentifier());

        Map<Date, List<Partner>> countryPartnerInvitations = this.getAttendeesByDate();

        int numberOfAttendeesForInvitationDate = -1;

        for (Date potentialDate : countryPartnerInvitations.keySet())
        {
            List<Partner> partnerList = countryPartnerInvitations.get(potentialDate);

            if(partnerList.size() > numberOfAttendeesForInvitationDate)
            {
                numberOfAttendeesForInvitationDate = partnerList.size();
                retVal.setStartDate(potentialDate);
                retVal.setAttendees(partnerList);
            }
        }

        return retVal;
    }
}
