﻿using System;
using ORTmaps.Apps;

public class Locations
{
    public int LocationId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }

    public Locations(int locid, string title, string desc, double latitude, double longitude)
    {
        this.LocationId = locid;
        this.Title = title;
        this.Description = desc;
        this.Latitude = latitude;
        this.Longitude = longitude;
    }
}

public class LocationLists
{
    public IEnumerable<Locations> LocationList { get; set; }
    public partial class Mapa : Form
    {
        public Mapa()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Mapa_Load(object sender, EventArgs e)
        {

        }
    }
}
}
public class HomeController : Controller
{
    public ActionResult Index()
    {
        ORTmaps.Apps.LocationLists model = new LocationLists();
        var locations = new List<Locations>()
            {
                new Locations(1, "Bhubaneswar","Bhubaneswar, Odisha", 20.296059, 85.824539),
                new Locations(2, "Hyderabad","Hyderabad, Telengana", 17.387140, 78.491684),
                new Locations(3, "Bengaluru","Bengaluru, Karnataka", 12.972442, 77.580643)
            };
        model.LocationList = locations;
        return View(model);
    }

    private ActionResult View(ORTmaps.Apps.LocationLists model)
    {
        throw new NotImplementedException();
    }

    private ActionResult View(LocationLists model)
    {
        throw new NotImplementedException();
    }
}

public class Controller
{
}