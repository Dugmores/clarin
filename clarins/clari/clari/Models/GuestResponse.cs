

using System;
using System.ComponentModel.DataAnnotations;

namespace clari.Models;

public class GuestResponse
{

    [Required(ErrorMessage = "Please enter your name")]
    public string? Name{get; set;}
    [Required(ErrorMessage = "Please enter your email")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address")]
    public string? Email{get;set;}
    [Required(ErrorMessage = "Please enter your phone number")]
    public string? Phone{get;set;}
    [Required(ErrorMessage = "Please indicate whether you will attend")]
    public bool? WillAttend{get;set;}

}