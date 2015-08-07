//
//  Home.swift
//  PROJ3I
//
//  Created by Nuno Batalha on 7/16/15.
//  Copyright (c) 2015 Nuno Batalha. All rights reserved.
//

import Foundation

class Home: UIViewController {
    
    @IBOutlet weak var webView: UIWebView!
    
    override func viewDidLoad() {
        self.view.addGestureRecognizer(self.revealViewController().panGestureRecognizer())
        let url = NSURL(string: "http://www.tos.pt")
        let requestObj = NSURLRequest(URL: url!)
        webView.loadRequest(requestObj)
    }
}