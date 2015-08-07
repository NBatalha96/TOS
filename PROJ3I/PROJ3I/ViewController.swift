//
//  ViewController.swift
//  PROJ1I
//
//  Created by Nuno Batalha on 5/26/15.
//  Copyright (c) 2015 Nuno Batalha. All rights reserved.
//

import UIKit

class ViewController: UITableViewController{
    
    var lists = [String]()

    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view, typically from a nib.
        
        self.view.addGestureRecognizer(self.revealViewController().panGestureRecognizer())
        
        self.title = "TOS_POSTS"
        
        var http = NSURL(string: "http://192.168.2.39/TOSWEB/Webservice/service.php")
        var data = NSData(contentsOfURL: http!)
        
        if let json : NSDictionary = NSJSONSerialization.JSONObjectWithData(data!, options: NSJSONReadingOptions.MutableContainers, error: nil) as? NSDictionary {
            if let items = json["tos_posts"] as? NSArray {
                for item in items {
                    var clas : Repo = Repo(json: item as! NSDictionary)
                    self.lists += [clas.title]
                    }
            }
        }
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }

    override func tableView(tableView: UITableView, numberOfRowsInSection section: Int) -> Int {
        return self.lists.count
    }
    
    override func tableView(tableView: UITableView, cellForRowAtIndexPath indexPath: NSIndexPath) -> UITableViewCell {
        let cell = self.tableView.dequeueReusableCellWithIdentifier("Cell", forIndexPath: indexPath) as! UITableViewCell
        
        var list : String
        
        list = lists[indexPath.row]
        
        cell.textLabel?.text = list
        
        return cell
    }

}

