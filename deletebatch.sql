create procedure  deletebatch(batchcode varchar) 
is
begin

   delete from payments
   where bcode = batchcode;

    delete from students
    where bcode = batchcode;

    delete from batches
    where bcode = batchcode;

end;
/
