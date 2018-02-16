package com.acorrea.hubspot.Web.Controllers;

import com.acorrea.hubspot.DomainModel.Invitation;
import com.acorrea.hubspot.DomainModel.Partner;
import com.acorrea.hubspot.Services.HubspotService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;

import java.util.List;

/**
 * Created by acorrea on 1/30/2018.
 */
@Controller
public class HubspotController
{
    @Autowired
    HubspotService hubspotService;

    @RequestMapping( value = {"/"})
    public String index(Model viewModel)
    {
        return "index";
    }

    @RequestMapping( value = {"/doWork"})
    public String doWork(Model viewModel)
    {
        List<Partner> partners = this.hubspotService.getPartners();

        List<Invitation> invitations = this.hubspotService.getPartnerInvitations(partners);

        boolean successfullPost = this.hubspotService.sendInvitations(invitations);

        if(successfullPost==true)
        {
            System.out.println("Successfull post");
        }

        return "index";
    }
}
