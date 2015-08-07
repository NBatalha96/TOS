//
//  Client.swift
//  PROJ3I
//
//  Created by Nuno Batalha on 7/16/15.
//  Copyright (c) 2015 Nuno Batalha. All rights reserved.
//

import Foundation
import CoreLocation

class Client: UIViewController, CLLocationManagerDelegate {
    
    @IBOutlet weak var Local: UILabel!
    @IBOutlet weak var Country: UILabel!
    @IBOutlet weak var AdminArea: UILabel!
    @IBOutlet weak var PCode: UILabel!
    let locationManager = CLLocationManager()
    
    override func viewDidLoad() {
        self.view.addGestureRecognizer(self.revealViewController().panGestureRecognizer())
        
        self.locationManager.delegate = self
        self.locationManager.desiredAccuracy = kCLLocationAccuracyBest
        self.locationManager.requestWhenInUseAuthorization()
        self.locationManager.startUpdatingLocation()
    }
    
    func locationManager(manager: CLLocationManager!, didUpdateLocations locations: [AnyObject]!) {
        CLGeocoder().reverseGeocodeLocation(manager.location, completionHandler: { (placemarks, error) -> Void in
            
            if error != nil
            {
                println("Error: " + error.localizedDescription)
                return
            }
            
            if placemarks.count > 0
            {
                let pm = placemarks[0] as! CLPlacemark
                self.displayLocationInfo(pm)
            }
            
        })
    }
    
    func displayLocationInfo(placemark: CLPlacemark)
    {
        self.locationManager.stopUpdatingLocation()
        println(placemark.locality)
        Local.text = placemark.locality
        println(placemark.postalCode)
        PCode.text = placemark.postalCode
        println(placemark.administrativeArea)
        AdminArea.text = placemark.administrativeArea
        println(placemark.country)
        Country.text = placemark.country
    }
    
    func locationManager(manager: CLLocationManager!, didFailWithError error: NSError!) {
        println("Error: " + error.localizedDescription)
    }
}