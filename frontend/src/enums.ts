// ---------------------------------------------------------------------------
// Enum definitions — auto-generated from ER model
// Maps integer values to display labels for enum fields
// ---------------------------------------------------------------------------

// PurchaseRequest.status
export const PurchaseRequestStatusMap: Record<string, string> = {
  '0': 'Draft',
  '1': 'PendingManagerApproval',
  '2': 'PendingFinanceApproval',
  '3': 'Approved',
  '4': 'Ordered',
  '5': 'Cancelled'
};
export const PurchaseRequestStatusOptions = [
  { label: 'Draft', value: '0' },
  { label: 'PendingManagerApproval', value: '1' },
  { label: 'PendingFinanceApproval', value: '2' },
  { label: 'Approved', value: '3' },
  { label: 'Ordered', value: '4' },
  { label: 'Cancelled', value: '5' }
];

// PurchaseOrder.status
export const PurchaseOrderStatusMap: Record<string, string> = {
  '0': 'Draft',
  '1': 'Sent',
  '2': 'PartiallyDelivered',
  '3': 'Delivered',
  '4': 'Cancelled'
};
export const PurchaseOrderStatusOptions = [
  { label: 'Draft', value: '0' },
  { label: 'Sent', value: '1' },
  { label: 'PartiallyDelivered', value: '2' },
  { label: 'Delivered', value: '3' },
  { label: 'Cancelled', value: '4' }
];
