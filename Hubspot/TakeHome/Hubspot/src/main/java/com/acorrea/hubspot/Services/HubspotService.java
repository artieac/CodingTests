package com.acorrea.hubspot.Services;

import com.acorrea.hubspot.DataLayer.Repositories.HubspotRepository;
import com.acorrea.hubspot.DomainModel.Country;
import com.acorrea.hubspot.DomainModel.Invitation;
import com.acorrea.hubspot.DomainModel.Partner;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * Created by acorrea on 1/30/2018.
 */
@Component
public class HubspotService
{
    private HubspotRepository hubspotRepository;

    @Autowired
    public HubspotService(HubspotRepository hubspotRepository)
    {
        this.hubspotRepository = hubspotRepository;
    }

    public List<Partner> getPartners()
    {
        return this.hubspotRepository.getPartners();
    }

    public Map<String, Country> groupPartnersByCountry(List<Partner> partners)
    {
        Map<String, Country> retVal = new HashMap<String, Country>();

        for (Partner partner : partners)
        {
            List<Partner> partnerList = new ArrayList<Partner>();

            if (retVal.containsKey(partner.getCountry()))
            {
                Country targetCountry = retVal.get(partner.getCountry());
                targetCountry.addPartner(partner);
            }
            else
            {
                Country newCountry = new Country(partner.getCountry());
                newCountry.addPartner(partner);
                retVal.put(newCountry.getIdentifier(), newCountry);
            }
        }

        return retVal;
    }

    public List<Invitation> getPartnerInvitations(List<Partner> partners)
    {
        List<Invitation> retVal = new ArrayList<Invitation>();

        Map<String, Country> partnersByCountry = groupPartnersByCountry(partners);

        for (String countryIdentifier : partnersByCountry.keySet())
        {
            Country currentCountry = partnersByCountry.get(countryIdentifier);
            retVal.add(currentCountry.findInvitationDate());
        }

        return retVal;
    }

    public boolean sendInvitations(List<Invitation> invitations)
    {
        return this.hubspotRepository.sendInvitations(invitations);
    }
}
