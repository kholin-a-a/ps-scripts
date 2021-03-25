import { BaseComponent } from "@everys/aurelia-components-abstractions";
import { autoinject } from "aurelia-framework";

@autoinject
export class $(CebabToCamelCase($Name)) extends BaseComponent {
  constructor(
  ) {
    super("$(CebabToCamelCase($Name))");
  }
}
