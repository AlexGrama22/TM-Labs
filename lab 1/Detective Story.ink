//Grama Alexandru & Spataru Dionisie

-> Start
===Start
# IMAGE: 1.png 
*You are a detective investigating a crime scene. The room is a mess, with overturned furniture, broken glass, and blood stains on the carpet.



-> Game

    ->END

==Game
VAR evidence = 0
VAR suspect = "unknown"


 * Investigate the scene.
-> Investigate
    ->END
    
 * Interview witnesses.
 -> Interview
    ->END
    
->END  
->END 
->END


=== Investigate
As you search the room, you find a broken vase, a discarded glove, and a scrap of paper with a phone number written on it. You collect the evidence and analyze it back at the station.
~evidence++
~suspect = "Jane"

 * Exit the room. 
 -> exit
    ->END 


->END 
=== Interview 
You speak with several witnesses, each providing different accounts of the events leading up to the crime. One witness mentions seeing a person matching the description of a known criminal in the area.
~evidence++
~suspect = "John"
 * Exit the room. 
 -> exit
    ->END 
->END 
=== exit 
You leave the room, but can't shake the feeling that there's more to the case than meets the eye.


 * Investigate the scene.
-> InvestigateComplete
    ->END
    
 * Interview witnesses.
 -> InterviewComplete
    ->END
    
 * Wait 5 minutes.
 -> ExitComplete 
    ->END
->END  
->END 


=== InvestigateComplete
Back at the station, you piece together the evidence you've collected. You identify the broken vase as a potential weapon and the phone number on the scrap of paper as belonging to the suspect's accomplice.
 * Confront Jane.
-> ConfrontJane
    ->END
 * Keep investigating.
-> InvestigateMore
    ->END    

->END     
=== InterviewComplete 
After speaking with the witnesses, you compare their accounts and discover inconsistencies in their stories. You suspect one of them is lying.
~evidence++
 * Confront John.
-> ConfrontJohn
    ->END
 * Keep investigating.
-> InvestigateMore
    ->END    

->END     
=== ExitComplete 
As being near the building for 5 minutes, you hear a noise coming from the hallway. You investigate and discover a witness who had previously been unaccounted for.
~evidence++
 * Confront witness.
-> ConfrontWitness
    ->END
 * Continue investigating.
-> InvestigateMore
    ->END    
->END 

=== ConfrontWitness 
You confront the suspect and discover he has an alibi for the time of the crime. However, he tells you he knows who the real culprit is.
~evidence++
-> End
->END 
=== ConfrontJohn 
VAR person = "John"

Detective: Good evening, Sir. Thank you for coming in today. Could you tell me what you witnessed?

{person}: I was walking my dog in the park last today around 21:00  when I saw something strange.

Detective: Can you please describe what you saw?

{person}: Yes, I saw a woman wearing a dark hoodie and jeans walking around the house. She seemed nervous and kept looking over her shoulder. Then, she disappeared behind a tree.

Detective: Did you see anything else? Did you see anyone else in the area?

{person}: No, I didn't see anyone else in the area. But I heard a loud noise, like a gunshot, a few minutes later.

Detective: Thank you for that information. Did you see which direction the woman went after she disappeared behind the tree?

{person}: No, I didn't. I was too far away to see where she went.

Detective: Okay, that's fine. Can you describe the woman's appearance in more detail? Did you see her face?

{person}: No, I didn't see her face, but she was about 164 and had a medium build. She was also wearing a black baseball cap.

Detective: Alright, thank you for your cooperation, {person}. We'll be in touch if we need any more information.
~evidence++
-> End
->END 
=== ConfrontJane 
You track down the suspect and confront her with the evidence you've gathered. After a tense standoff, she confesses to the crime.
~evidence+=3
-> End
->END 
=== InvestigateMore
You continue your investigation to gather more evidence, but the case remains unsolved.
-> End
->END
=== End ===
{ evidence <= 3:
    You failled to find the killer, but it was a dream and now you can get up to solve te case.
    -> InvestigateComplete
    - else:
    You managed to solve the case,the killer is {suspect}
    }
    -> END
->END    
