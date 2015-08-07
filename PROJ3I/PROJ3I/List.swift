//
//  List.swift
//  PROJ1I
//
//  Created by Nuno Batalha on 5/26/15.
//  Copyright (c) 2015 Nuno Batalha. All rights reserved.
//

import Foundation

class Repo
{
    var id : String
    var title : String
    
    init (json : NSDictionary)
    {
        self.id = json["ID"] as! String
        self.title = json["post_title"] as! String
    }
}