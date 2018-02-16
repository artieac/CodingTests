package com.acorrea.hubspot.DataLayer.Entities;

import com.acorrea.hubspot.DomainModel.Partner;
import com.fasterxml.jackson.annotation.JsonProperty;

import java.util.List;

/**
 * Created by acorrea on 1/30/2018.
 */
public class PartnersGetEntity
{
    List<Partner> partners;

    @JsonProperty("partners")
    public List<Partner> getPartners() { return this.partners;}
    @JsonProperty("partners")
    public void setPartners(List<Partner> value) { this.partners = value;}
}
