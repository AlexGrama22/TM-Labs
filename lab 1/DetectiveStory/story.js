var storyContent = ﻿{"inkVersion":20,"root":[[{"->":"Start"},["done",{"#f":5,"#n":"g-0"}],null],"done",{"Start":[[{"#":"IMAGE: 1.png"},["ev",{"^->":"Start.0.1.$r1"},{"temp=":"$r"},"str",{"->":".^.s"},[{"#n":"$r1"}],"/str","/ev",{"*":".^.^.c-0","flg":18},{"s":["^You are a detective investigating a crime scene. The room is a mess, with overturned furniture, broken glass, and blood stains on the carpet.",{"->":"$r","var":true},null]}],{"c-0":["ev",{"^->":"Start.0.c-0.$r2"},"/ev",{"temp=":"$r"},{"->":".^.^.1.s"},[{"#n":"$r2"}],"\n",{"->":"Game"},"end",{"#f":5}]}],{"#f":1}],"Game":[[["ev",{"^->":"Game.0.0.$r1"},{"temp=":"$r"},"str",{"->":".^.s"},[{"#n":"$r1"}],"/str","/ev",{"*":".^.^.c-0","flg":18},{"s":["^Investigate the scene.",{"->":"$r","var":true},null]}],["ev",{"^->":"Game.0.1.$r1"},{"temp=":"$r"},"str",{"->":".^.s"},[{"#n":"$r1"}],"/str","/ev",{"*":".^.^.c-1","flg":18},{"s":["^Interview witnesses.",{"->":"$r","var":true},null]}],{"c-0":["ev",{"^->":"Game.0.c-0.$r2"},"/ev",{"temp=":"$r"},{"->":".^.^.0.s"},[{"#n":"$r2"}],"\n",{"->":"Investigate"},"end",{"#f":5}],"c-1":["ev",{"^->":"Game.0.c-1.$r2"},"/ev",{"temp=":"$r"},{"->":".^.^.1.s"},[{"#n":"$r2"}],"\n",{"->":"Interview"},"end","end","end","end",{"#f":5}]}],{"#f":1}],"Investigate":[["^As you search the room, you find a broken vase, a discarded glove, and a scrap of paper with a phone number written on it. You collect the evidence and analyze it back at the station.","\n","ev",{"VAR?":"evidence"},1,"+",{"VAR=":"evidence","re":true},"/ev","ev","str","^Jane","/str","/ev",{"VAR=":"suspect","re":true},["ev",{"^->":"Investigate.0.14.$r1"},{"temp=":"$r"},"str",{"->":".^.s"},[{"#n":"$r1"}],"/str","/ev",{"*":".^.^.c-0","flg":18},{"s":["^Exit the room. ",{"->":"$r","var":true},null]}],{"c-0":["ev",{"^->":"Investigate.0.c-0.$r2"},"/ev",{"temp=":"$r"},{"->":".^.^.14.s"},[{"#n":"$r2"}],"\n",{"->":"exit"},"end","end",{"#f":5}]}],{"#f":1}],"Interview":[["^You speak with several witnesses, each providing different accounts of the events leading up to the crime. One witness mentions seeing a person matching the description of a known criminal in the area.","\n","ev",{"VAR?":"evidence"},1,"+",{"VAR=":"evidence","re":true},"/ev","ev","str","^John","/str","/ev",{"VAR=":"suspect","re":true},["ev",{"^->":"Interview.0.14.$r1"},{"temp=":"$r"},"str",{"->":".^.s"},[{"#n":"$r1"}],"/str","/ev",{"*":".^.^.c-0","flg":18},{"s":["^Exit the room. ",{"->":"$r","var":true},null]}],{"c-0":["ev",{"^->":"Interview.0.c-0.$r2"},"/ev",{"temp=":"$r"},{"->":".^.^.14.s"},[{"#n":"$r2"}],"\n",{"->":"exit"},"end","end",{"#f":5}]}],{"#f":1}],"exit":[["^You leave the room, but can't shake the feeling that there's more to the case than meets the eye.","\n",["ev",{"^->":"exit.0.2.$r1"},{"temp=":"$r"},"str",{"->":".^.s"},[{"#n":"$r1"}],"/str","/ev",{"*":".^.^.c-0","flg":18},{"s":["^Investigate the scene.",{"->":"$r","var":true},null]}],["ev",{"^->":"exit.0.3.$r1"},{"temp=":"$r"},"str",{"->":".^.s"},[{"#n":"$r1"}],"/str","/ev",{"*":".^.^.c-1","flg":18},{"s":["^Interview witnesses.",{"->":"$r","var":true},null]}],["ev",{"^->":"exit.0.4.$r1"},{"temp=":"$r"},"str",{"->":".^.s"},[{"#n":"$r1"}],"/str","/ev",{"*":".^.^.c-2","flg":18},{"s":["^Wait 5 minutes.",{"->":"$r","var":true},null]}],{"c-0":["ev",{"^->":"exit.0.c-0.$r2"},"/ev",{"temp=":"$r"},{"->":".^.^.2.s"},[{"#n":"$r2"}],"\n",{"->":"InvestigateComplete"},"end",{"#f":5}],"c-1":["ev",{"^->":"exit.0.c-1.$r2"},"/ev",{"temp=":"$r"},{"->":".^.^.3.s"},[{"#n":"$r2"}],"\n",{"->":"InterviewComplete"},"end",{"#f":5}],"c-2":["ev",{"^->":"exit.0.c-2.$r2"},"/ev",{"temp=":"$r"},{"->":".^.^.4.s"},[{"#n":"$r2"}],"\n",{"->":"ExitComplete"},"end","end","end",{"#f":5}]}],{"#f":1}],"InvestigateComplete":[["^Back at the station, you piece together the evidence you've collected. You identify the broken vase as a potential weapon and the phone number on the scrap of paper as belonging to the suspect's accomplice.","\n",["ev",{"^->":"InvestigateComplete.0.2.$r1"},{"temp=":"$r"},"str",{"->":".^.s"},[{"#n":"$r1"}],"/str","/ev",{"*":".^.^.c-0","flg":18},{"s":["^Confront Jane.",{"->":"$r","var":true},null]}],["ev",{"^->":"InvestigateComplete.0.3.$r1"},{"temp=":"$r"},"str",{"->":".^.s"},[{"#n":"$r1"}],"/str","/ev",{"*":".^.^.c-1","flg":18},{"s":["^Keep investigating.",{"->":"$r","var":true},null]}],{"c-0":["ev",{"^->":"InvestigateComplete.0.c-0.$r2"},"/ev",{"temp=":"$r"},{"->":".^.^.2.s"},[{"#n":"$r2"}],"\n",{"->":"ConfrontJane"},"end",{"#f":5}],"c-1":["ev",{"^->":"InvestigateComplete.0.c-1.$r2"},"/ev",{"temp=":"$r"},{"->":".^.^.3.s"},[{"#n":"$r2"}],"\n",{"->":"InvestigateMore"},"end","end",{"#f":5}]}],{"#f":1}],"InterviewComplete":[["^After speaking with the witnesses, you compare their accounts and discover inconsistencies in their stories. You suspect one of them is lying.","\n","ev",{"VAR?":"evidence"},1,"+",{"VAR=":"evidence","re":true},"/ev",["ev",{"^->":"InterviewComplete.0.8.$r1"},{"temp=":"$r"},"str",{"->":".^.s"},[{"#n":"$r1"}],"/str","/ev",{"*":".^.^.c-0","flg":18},{"s":["^Confront John.",{"->":"$r","var":true},null]}],["ev",{"^->":"InterviewComplete.0.9.$r1"},{"temp=":"$r"},"str",{"->":".^.s"},[{"#n":"$r1"}],"/str","/ev",{"*":".^.^.c-1","flg":18},{"s":["^Keep investigating.",{"->":"$r","var":true},null]}],{"c-0":["ev",{"^->":"InterviewComplete.0.c-0.$r2"},"/ev",{"temp=":"$r"},{"->":".^.^.8.s"},[{"#n":"$r2"}],"\n",{"->":"ConfrontJohn"},"end",{"#f":5}],"c-1":["ev",{"^->":"InterviewComplete.0.c-1.$r2"},"/ev",{"temp=":"$r"},{"->":".^.^.9.s"},[{"#n":"$r2"}],"\n",{"->":"InvestigateMore"},"end","end",{"#f":5}]}],{"#f":1}],"ExitComplete":[["^As being near the building for 5 minutes, you hear a noise coming from the hallway. You investigate and discover a witness who had previously been unaccounted for.","\n","ev",{"VAR?":"evidence"},1,"+",{"VAR=":"evidence","re":true},"/ev",["ev",{"^->":"ExitComplete.0.8.$r1"},{"temp=":"$r"},"str",{"->":".^.s"},[{"#n":"$r1"}],"/str","/ev",{"*":".^.^.c-0","flg":18},{"s":["^Confront witness.",{"->":"$r","var":true},null]}],["ev",{"^->":"ExitComplete.0.9.$r1"},{"temp=":"$r"},"str",{"->":".^.s"},[{"#n":"$r1"}],"/str","/ev",{"*":".^.^.c-1","flg":18},{"s":["^Continue investigating.",{"->":"$r","var":true},null]}],{"c-0":["ev",{"^->":"ExitComplete.0.c-0.$r2"},"/ev",{"temp=":"$r"},{"->":".^.^.8.s"},[{"#n":"$r2"}],"\n",{"->":"ConfrontWitness"},"end",{"#f":5}],"c-1":["ev",{"^->":"ExitComplete.0.c-1.$r2"},"/ev",{"temp=":"$r"},{"->":".^.^.9.s"},[{"#n":"$r2"}],"\n",{"->":"InvestigateMore"},"end","end",{"#f":5}]}],{"#f":1}],"ConfrontWitness":["^You confront the suspect and discover he has an alibi for the time of the crime. However, he tells you he knows who the real culprit is.","\n","ev",{"VAR?":"evidence"},1,"+",{"VAR=":"evidence","re":true},"/ev",{"->":"End"},"end",{"#f":1}],"ConfrontJohn":["^Detective: Good evening, Sir. Thank you for coming in today. Could you tell me what you witnessed?","\n","ev",{"VAR?":"person"},"out","/ev","^: I was walking my dog in the park last today around 21:00  when I saw something strange.","\n","^Detective: Can you please describe what you saw?","\n","ev",{"VAR?":"person"},"out","/ev","^: Yes, I saw a woman wearing a dark hoodie and jeans walking around the house. She seemed nervous and kept looking over her shoulder. Then, she disappeared behind a tree.","\n","^Detective: Did you see anything else? Did you see anyone else in the area?","\n","ev",{"VAR?":"person"},"out","/ev","^: No, I didn't see anyone else in the area. But I heard a loud noise, like a gunshot, a few minutes later.","\n","^Detective: Thank you for that information. Did you see which direction the woman went after she disappeared behind the tree?","\n","ev",{"VAR?":"person"},"out","/ev","^: No, I didn't. I was too far away to see where she went.","\n","^Detective: Okay, that's fine. Can you describe the woman's appearance in more detail? Did you see her face?","\n","ev",{"VAR?":"person"},"out","/ev","^: No, I didn't see her face, but she was about 164 and had a medium build. She was also wearing a black baseball cap.","\n","^Detective: Alright, thank you for your cooperation, ","ev",{"VAR?":"person"},"out","/ev","^. We'll be in touch if we need any more information.","\n","ev",{"VAR?":"evidence"},1,"+",{"VAR=":"evidence","re":true},"/ev",{"->":"End"},"end",{"#f":1}],"ConfrontJane":["^You track down the suspect and confront her with the evidence you've gathered. After a tense standoff, she confesses to the crime.","\n","ev",{"VAR?":"evidence"},3,"+",{"VAR=":"evidence","re":true},"/ev",{"->":"End"},"end",{"#f":1}],"InvestigateMore":["^You continue your investigation to gather more evidence, but the case remains unsolved.","\n",{"->":"End"},"end",{"#f":1}],"End":["ev",{"VAR?":"evidence"},3,"<=","/ev",[{"->":".^.b","c":true},{"b":["\n","^You failled to find the killer, but it was a dream and now you can get up to solve te case.","\n",{"->":"InvestigateComplete"},{"->":"End.7"},null]}],[{"->":".^.b"},{"b":["\n","^You managed to solve the case,the killer is ","ev",{"VAR?":"suspect"},"out","/ev","\n",{"->":"End.7"},null]}],"nop","\n","end","end",{"#f":1}],"global decl":["ev",0,{"VAR=":"evidence"},"str","^unknown","/str",{"VAR=":"suspect"},"str","^John","/str",{"VAR=":"person"},"/ev","end",null],"#f":1}],"listDefs":{}};