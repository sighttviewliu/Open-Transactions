/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace OpenTransactions.OTAPI {

public class AddressBook : Storable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal AddressBook(global::System.IntPtr cPtr, bool cMemoryOwn) : base(otapiPINVOKE.AddressBook_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AddressBook obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~AddressBook() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          otapiPINVOKE.delete_AddressBook(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public uint GetContactCount() {
    uint ret = otapiPINVOKE.AddressBook_GetContactCount(swigCPtr);
    return ret;
  }

  public Contact GetContact(uint nIndex) {
    global::System.IntPtr cPtr = otapiPINVOKE.AddressBook_GetContact(swigCPtr, nIndex);
    Contact ret = (cPtr == global::System.IntPtr.Zero) ? null : new Contact(cPtr, false);
    return ret;
  }

  public bool RemoveContact(uint nIndexContact) {
    bool ret = otapiPINVOKE.AddressBook_RemoveContact(swigCPtr, nIndexContact);
    return ret;
  }

  public bool AddContact(Contact disownObject) {
    bool ret = otapiPINVOKE.AddressBook_AddContact(swigCPtr, Contact.getCPtr(disownObject));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static AddressBook ot_dynamic_cast(Storable pObject) {
    global::System.IntPtr cPtr = otapiPINVOKE.AddressBook_ot_dynamic_cast(Storable.getCPtr(pObject));
    AddressBook ret = (cPtr == global::System.IntPtr.Zero) ? null : new AddressBook(cPtr, false);
    return ret;
  }

}

}
