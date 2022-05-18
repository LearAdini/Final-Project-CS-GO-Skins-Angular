import { ToastrService } from 'ngx-toastr';

import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, CanDeactivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { AccountService } from '../service/account.service';
import { AccountEditComponent } from '../account-edit/account-edit.component';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate  {

  constructor(
    private accountService:AccountService,
    private toastr:ToastrService,
    private router: Router
  ) { }

  canActivate(): Observable<boolean> {
    return this.accountService.currentUser$.pipe(
      map(user => {
        if (user) return true;
        this.toastr.error('You must sign up to view products 🔐');
        this.router.navigateByUrl('/home');
        return false;
      })
    )
  }

}

// @Injectable({
//   providedIn: 'root'
// })
// export class AccountEditChangesGuard implements CanDeactivate<AccountEditComponent> {

//   canDeactivate(
//     component: AccountEditComponent): boolean {
//     if(component.editForm.dirty){
//       return confirm("Are you sure you want to continue? any unsaved changes will be lost...")
//     }
//     if(component?.cardForm.dirty){
//       return confirm("Are you sure you want to continue? any unsaved changes will be lost...")
//     }
//     return true;
//   }
// }
