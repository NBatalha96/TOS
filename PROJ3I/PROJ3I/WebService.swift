//
//  WebService.swift
//  PROJ3I
//
//  Created by Nuno Batalha on 7/16/15.
//  Copyright (c) 2015 Nuno Batalha. All rights reserved.
//

import Foundation

class WebService: UIViewController {
    override func viewDidLoad() {
        self.view.addGestureRecognizer(self.revealViewController().panGestureRecognizer())
    }
}