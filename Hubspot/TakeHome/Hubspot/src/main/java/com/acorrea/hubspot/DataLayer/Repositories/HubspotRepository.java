package com.acorrea.hubspot.DataLayer.Repositories;

import com.acorrea.hubspot.DataLayer.Entities.CountryPostEntity;
import com.acorrea.hubspot.DataLayer.Entities.PartnersGetEntity;
import com.acorrea.hubspot.DomainModel.Invitation;
import com.acorrea.hubspot.DomainModel.Partner;
import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import org.springframework.http.*;
import org.springframework.stereotype.Repository;
import org.springframework.web.client.HttpStatusCodeException;
import org.springframework.web.client.RestTemplate;

import java.util.List;

/**
 * Created by acorrea on 1/30/2018.
 */
@Repository
public class HubspotRepository
{
    private static String getUrl = "https://candidate.hubteam.com/candidateTest/v2/partners?userKey=e6e622b8eb024bc9b94d77e7d966";
    private static String postUrl = "https://candidate.hubteam.com/candidateTest/v2/results?userKey=e6e622b8eb024bc9b94d77e7d966";

    public List<Partner> getPartners()
    {
        List<Partner> retVal = null;

        String targetUrl = getUrl;

        RestTemplate restTemplate = new RestTemplate();
        HttpHeaders headers = new HttpHeaders();
        headers.setContentType(MediaType.APPLICATION_JSON_UTF8);
        HttpEntity<String> entity = new HttpEntity<String>(headers);
        ResponseEntity<PartnersGetEntity> response = restTemplate.exchange(targetUrl, HttpMethod.GET, entity, PartnersGetEntity.class);

        if(response != null)
        {
            if (response.getBody() != null)
            {
                retVal = response.getBody().getPartners();
            }
        }

        return retVal;
    }

    private String generateInvitationJSON(List<Invitation> invitations)
    {
        ObjectMapper objectMapper = new ObjectMapper();
        String retVal = "";

        CountryPostEntity countryPost = new CountryPostEntity(invitations);

        try
        {
            retVal = objectMapper.writeValueAsString(countryPost);
        }
        catch (JsonProcessingException e)
        {
            e.printStackTrace();
        }

        return retVal;
    }

    public boolean sendInvitations(List<Invitation> invitations)
    {
        boolean retVal = false;

        String targetUrl = postUrl;

        RestTemplate restTemplate = new RestTemplate();
        HttpHeaders headers = new HttpHeaders();
        headers.setContentType(MediaType.APPLICATION_JSON_UTF8);
        HttpEntity<String> entity = new HttpEntity<String>(this.generateInvitationJSON(invitations), headers);

        try
        {
            ResponseEntity<String> response = restTemplate.postForEntity(targetUrl, entity, String.class);

            if(response != null)
            {
                if(response.getStatusCode()==HttpStatus.OK)
                {
                    retVal = true;
                }
            }
        }
        catch(HttpStatusCodeException statusCodeException)
        {
            statusCodeException.printStackTrace();
        }

        return retVal;
    }
}
